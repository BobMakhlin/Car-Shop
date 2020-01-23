/*
 * Car shop.
 * Copyright(C) 2020 Bob Makhlin
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
 * GNU General Public License for more details.
 * You should have received a copy of the GNU General Public License
 * along with this program.If not, see https://www.gnu.org/licenses/.
*/

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
