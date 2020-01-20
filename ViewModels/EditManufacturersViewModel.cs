using CarsShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.ViewModels
{
    class EditManufacturersViewModel
    {
        public ObservableCollection<Manufacturer> Manufacturers { get; set; }
    }
}
