using CarsShop.Models;
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
        #endregion

        public MainWindowViewModel()
        {
            InitCommands();

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
        }

        private void AddCar()
        {
            Cars.Add(new Car());
            CurrentCar = Cars.LastOrDefault();
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
