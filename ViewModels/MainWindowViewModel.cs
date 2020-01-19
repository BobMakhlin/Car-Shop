using CarsShop.Models;
using CarsShop.Services;
using CarsShop.Services.WindowServices.EditManufacturersService;
using GalaSoft.MvvmLight.Command;
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
        private Photo currentPhoto;
        #endregion

        public MainWindowViewModel(IDialogService dialogService, IEditManufacturersWndService manufacturersWndService)
        {
            InitCommands();

            // Init services.
            this.dialogService = dialogService;
            this.manufacturersWndService = manufacturersWndService;

            CurrentCarChanged += OnCurrentCarChanged;

            Cars = new CarsStorage();
            CurrentCar = Cars.FirstOrDefault();
            CurrentPhoto = CurrentCar.Photos.FirstOrDefault();

            CarClasses = new CarClassesStorage();
            CarColors = new NamedColorsStorage();
            CarManufacturers = new ManufacturersStorage();
        }

        public event EventHandler CurrentCarChanged;

        public ObservableCollection<Car> Cars { get; private set; }
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
            private set
            {
                currentPhoto = value;
                INotifyPropertyChanged();
            }
        }

        public List<string> CarClasses { get; private set; }
        public List<NamedColor> CarColors { get; set; }
        public ObservableCollection<Manufacturer> CarManufacturers { get; set; }

        public ICommand CommandAddCar { get; private set; }
        public ICommand CommandDeleteCurrentCar { get; private set; }
        public ICommand CommandEditManufacturers { get; private set; }
        public ICommand CommandSelectPrevPhoto { get; private set; }
        public ICommand CommandSelectNextPhoto { get; private set; }
        public ICommand CommandDeleteCurrentPhoto { get; private set; }
        public ICommand CommandOpenPhoto { get; private set; }

        void InitCommands()
        {
            CommandAddCar = new RelayCommand(AddCar);
            CommandDeleteCurrentCar = new RelayCommand(DeleteCurrentCar);
            CommandEditManufacturers = new RelayCommand(EditManufacturers);
            CommandSelectPrevPhoto = new RelayCommand(SelectPrevPhoto);
            CommandSelectNextPhoto = new RelayCommand(SelectNextPhoto);
            CommandDeleteCurrentPhoto = new RelayCommand(DeleteCurrentPhoto, DeleteCurrentPhotoCanExecute);
            CommandOpenPhoto = new RelayCommand(OpenPhoto);
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
