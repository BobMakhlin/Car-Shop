using CarsShop.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarsShop.ViewModels
{
    class EditManufacturersViewModel
    {
        public EditManufacturersViewModel()
        {
            InitCommands();
        }

        public ObservableCollection<Manufacturer> Manufacturers { get; set; }

        public ICommand CommandInitNewCategory { get; set; }

        private void InitCommands()
        {
            CommandInitNewCategory = new RelayCommand(InitCategory);
        }

        private void InitCategory()
        {
            Manufacturers.Last().Id = Manufacturers.Max(x => x.Id) + 1;
        }
    }
}
