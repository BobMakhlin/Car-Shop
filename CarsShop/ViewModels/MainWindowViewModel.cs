using CarsShop.AppData;
using CarsShop.DropHandlers;
using CarsShop.Helpers;
using CarsShop.Models;
using CarsShop.Services;
using CarsShop.Services.WindowServices;
using CarsShop.Services.WindowServices.EditManufacturersService;
using GalaSoft.MvvmLight.Command;
using GongSolutions.Wpf.DragDrop;
using PhotoAlbum.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace CarsShop.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Private Definitions
        private Car currentCar;
        IDialogService dialogService;
        IEditManufacturersWndService manufacturersWndService;
        IWindowService settingsService;
        private Photo currentPhoto;
        private ObservableCollection<Car> cars;
        #endregion

        public MainWindowViewModel(IDialogService dialogService, IEditManufacturersWndService manufacturersWndService, IWindowService settingsService)
        {
            InitCommands();

            ThemeManager.SetAppTheme(ThemeManager.GetThemesNames()[0]);

            // Init services.
            this.dialogService = dialogService;
            this.manufacturersWndService = manufacturersWndService;
            this.settingsService = settingsService;

            // Init drop handlers.
            ImageDropHandler = new ImageDropHandler(this);

            CurrentCarChanged += OnCurrentCarChanged;

            LoadProgramData();
        }

        public event EventHandler CurrentCarChanged;

        public ObservableCollection<Car> Cars
        {
            get => cars;
            private set
            {
                cars = value;
                INotifyPropertyChanged();
            }
        }
        public Car CurrentCar
        {
            get => currentCar;
            set
            {
                currentCar = value;
                INotifyPropertyChanged();
                CurrentCarChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public Photo CurrentPhoto
        {
            get => currentPhoto;
            set
            {
                currentPhoto = value;
                INotifyPropertyChanged();
            }
        }

        public List<string> CarClasses { get; private set; }
        public List<NamedColor> CarColors { get; set; }
        public ObservableCollection<Manufacturer> CarManufacturers { get; set; }

        public IDropTarget ImageDropHandler { get; private set; }
        public ICommand CommandAddCar { get; private set; }
        public ICommand CommandDeleteCurrentCar { get; private set; }
        public ICommand CommandEditManufacturers { get; private set; }
        public ICommand CommandSelectPrevPhoto { get; private set; }
        public ICommand CommandSelectNextPhoto { get; private set; }
        public ICommand CommandDeleteCurrentPhoto { get; private set; }
        public ICommand CommandOpenPhoto { get; private set; }
        public ICommand CommandProgramClosing { get; private set; }
        public ICommand CommandAzSort { get; private set; }
        public ICommand CommandZaSort { get; private set; }
        public ICommand CommandFromCheapToExpensiveSort { get; private set; }
        public ICommand CommandFromExpensiveToCheapSort { get; private set; }
        public ICommand CommandShowSettings { get; private set; }

        void InitCommands()
        {
            CommandAddCar = new RelayCommand(AddCar);
            CommandDeleteCurrentCar = new RelayCommand(DeleteCurrentCar);
            CommandEditManufacturers = new RelayCommand(EditManufacturers);
            CommandSelectPrevPhoto = new RelayCommand(SelectPrevPhoto);
            CommandSelectNextPhoto = new RelayCommand(SelectNextPhoto);
            CommandDeleteCurrentPhoto = new RelayCommand(DeleteCurrentPhoto, DeleteCurrentPhotoCanExecute);
            CommandOpenPhoto = new RelayCommand(OpenPhoto);
            CommandProgramClosing = new RelayCommand(OnProgramClosing);
            CommandAzSort = new RelayCommand(AzSortCars);
            CommandZaSort = new RelayCommand(ZaSortCars);
            CommandFromCheapToExpensiveSort = new RelayCommand(SortFromCheapToExpensive);
            CommandFromExpensiveToCheapSort = new RelayCommand(SortCommandFromExpensiveToCheap);
            CommandShowSettings = new RelayCommand(ShowSettings);
        }
        
        void LoadProgramData()
        {
            try
            {
                Cars = AppDataManager.LoadCars(AppFiles.CarsPath);
            }
            catch (Exception)
            {
                Cars = new CarsStorage();
            }

            try
            {
                CarManufacturers = AppDataManager.LoadManufacturers(AppFiles.ManufacturersPath);
            }
            catch (Exception)
            {
                CarManufacturers = new ManufacturersStorage();
            }

            CurrentCar = Cars.FirstOrDefault();
            CurrentPhoto = CurrentCar.Photos.FirstOrDefault();
            CarClasses = new CarClassesStorage();
            CarColors = new NamedColorsStorage();
        }
        private void AddCar()
        {
            Cars.Add(new Car());
            CurrentCar = Cars.LastOrDefault();
        }
        private void DeleteCurrentCar()
        {
            if (dialogService.MessageBoxYesNo("Are you sure you want to delete the selected car?") == DialogResult.Yes)
            {
                Cars.Remove(CurrentCar);
                CurrentCar = Cars.LastOrDefault();
            }
        }
        private void EditManufacturers()
        {
            manufacturersWndService.Manufacturers = CarManufacturers;
            manufacturersWndService.ShowDialog();
        }
        private void OnCurrentCarChanged(object sender, EventArgs e)
        {
            CurrentPhoto = CurrentCar.Photos.FirstOrDefault();
        }
        private void SelectPrevPhoto()
        {
            var pos = CurrentCar.Photos.IndexOf(CurrentPhoto);

            if (pos != -1)
            {
                if (pos > 0)
                {
                    CurrentPhoto = CurrentCar.Photos[pos - 1];
                }
                else
                {
                    CurrentPhoto = CurrentCar.Photos.Last();
                }
            }
        }
        private void SelectNextPhoto()
        {
            var pos = CurrentCar.Photos.IndexOf(CurrentPhoto);

            if (pos != -1)
            {
                if (pos < CurrentCar.Photos.Count - 1)
                {
                    CurrentPhoto = CurrentCar.Photos[pos + 1];
                }
                else
                {
                    CurrentPhoto = CurrentCar.Photos.First();
                }
            }
        }
        private void DeleteCurrentPhoto()
        {
            if (dialogService.MessageBoxYesNo("Are you sure you want to delete this photo?") == DialogResult.Yes)
            {
                CurrentCar.Photos.Remove(CurrentPhoto);
                CurrentPhoto = CurrentCar.Photos.LastOrDefault();
            }
        }
        private bool DeleteCurrentPhotoCanExecute()
        {
            return CurrentCar.Photos.Count > 0;
        }
        private void OpenPhoto()
        {
            if (dialogService.OpenFileDialog())
            {
                if (FileFormat.IsImage(dialogService.File))
                {
                    var filename = Helper.CopyToImageDir(dialogService.File);
                    CurrentCar.Photos.Add(new Photo { Path = filename });
                    CurrentPhoto = CurrentCar.Photos.LastOrDefault();
                }
            }
        }
        private void OnProgramClosing()
        {
            AppDataManager.SaveCars(AppFiles.CarsPath, Cars);
            AppDataManager.SaveManufacturers(AppFiles.ManufacturersPath, CarManufacturers);
        }
        private void AzSortCars()
        {
            Cars = new ObservableCollection<Car>(Cars.OrderBy(x => x.Model));
            CurrentCar = Cars.FirstOrDefault();
        }
        private void ZaSortCars()
        {
            Cars = new ObservableCollection<Car>(Cars.OrderByDescending(x => x.Model));
            CurrentCar = Cars.FirstOrDefault();
        }
        private void SortFromCheapToExpensive()
        {
            Cars = new ObservableCollection<Car>(Cars.OrderBy(x => x.Price));
            CurrentCar = Cars.FirstOrDefault();
        }
        private void SortCommandFromExpensiveToCheap()
        {
            Cars = new ObservableCollection<Car>(Cars.OrderByDescending(x => x.Price));
            CurrentCar = Cars.FirstOrDefault();
        }
        private void ShowSettings()
        {
            settingsService.ShowDialog();
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void INotifyPropertyChanged([CallerMemberName] string prop = "")
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
