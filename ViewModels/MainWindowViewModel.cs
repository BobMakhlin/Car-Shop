using CarsShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.ViewModels
{
    class MainWindowViewModel
    {
        #region Private Definitions

        #endregion

        public MainWindowViewModel()
        {
            Cars = new CarsStorage();
        }

        public ObservableCollection<Car> Cars { get; private set; }

        #region INotifyPropertyChanged

        #endregion
    }
}
