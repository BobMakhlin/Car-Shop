using CarsShop.Models;
using CarsShop.Services;
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

namespace CarsShop.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Private Definitions
        private Car currentCar;
        IDialogService dialogService;
        #endregion

        public MainWindowViewModel(IDialogService dialogService)
        {
            InitCommands();

            // Init services.
            this.dialogService = dialogService;

            Cars = new CarsStorage();
            CurrentCar = Cars.FirstOrDefault();
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
        public ICommand CommandAddCar { get; private set; }
        public ICommand CommandDeleteCurrentCar { get; private set; }

        void InitCommands()
        {
            CommandAddCar = new RelayCommand(AddCar);
            CommandDeleteCurrentCar = new RelayCommand(DeleteCurrentCar);
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
