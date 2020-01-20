﻿using CarsShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Services.WindowServices.EditManufacturersService
{
    interface IEditManufacturersWndService : IWindowService
    {
        ObservableCollection<Manufacturer> Manufacturers { get; set; }
    }
}
