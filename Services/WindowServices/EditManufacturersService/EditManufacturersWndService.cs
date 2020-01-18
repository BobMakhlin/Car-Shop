using CarsShop.Models;
using CarsShop.ViewModels;
using CarsShop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Services.WindowServices.EditManufacturersService
{
    internal class EditManufacturersWndService : IEditManufacturersWndService
    {
        public ObservableCollection<Manufacturer> Manufacturers { get; set; }

        public void ShowDialog()
        {
            var vm = new EditManufacturersViewModel();
            vm.Manufacturers = Manufacturers;

            var window = new EditManufacturersWindow
            {
                DataContext = vm
            };

            window.ShowDialog();
        }
    }
}
