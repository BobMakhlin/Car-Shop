using CarsShop.Models;
using CarsShop.Services;
using CarsShop.Services.WindowServices.EditManufacturersService;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
        #endregion

        public MainWindowViewModel(IDialogService dialogService, IEditManufacturersWndService manufacturersWndService)
        {
            InitCommands();

            // Init services.
            this.dialogService = dialogService;
            this.manufacturersWndService = manufacturersWndService;

            Cars = new CarsStorage();
            CurrentCar = Cars.FirstOrDefault();
            CarClasses = new CarClassesStorage();
            CarColors = new NamedColorsStorage();
            CarManufacturers = new ManufacturersStorage();
        }

        public ObservableCollection<Car> Cars { get; private set; }
        public Car CurrentCar 
        {
            get => currentCar;
            set
            {
                currentCar = value;
                INotifyPropertyChanged();
            }
        }

        public List<string> CarClasses { get; private set; }
        public List<NamedColor> CarColors { get; set; }
        public ObservableCollection<Manufacturer> CarManufacturers { get; set; }

        public ICommand CommandAddCar { get; private set; }
        public ICommand CommandDeleteCurrentCar { get; private set; }
        public ICommand CommandEditManufacturers { get; private set; }

        void InitCommands()
        {
            CommandAddCar = new RelayCommand(AddCar);
            CommandDeleteCurrentCar = new RelayCommand(DeleteCurrentCar);
            CommandEditManufacturers = new RelayCommand(EditManufacturers);
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
