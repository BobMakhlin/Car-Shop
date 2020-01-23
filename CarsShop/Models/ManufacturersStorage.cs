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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarsShop.Models
{
    [Serializable]
    class ManufacturersStorage : ObservableCollection<Manufacturer>
    {
        public ManufacturersStorage()
        {
            this.Add(new Manufacturer { Id = 1, Name = "BMW", Country = "Germany" });
            this.Add(new Manufacturer { Id = 2, Name = "Audi", Country = "Germany" });
            this.Add(new Manufacturer { Id = 3, Name = "Porsche", Country = "Germany" });
            this.Add(new Manufacturer { Id = 4, Name = "Volkswagen", Country = "Germany" });
            this.Add(new Manufacturer { Id = 5, Name = "Chevrolet", Country = "USA" });
            this.Add(new Manufacturer { Id = 6, Name = "Cadillac", Country = "USA" });
            this.Add(new Manufacturer { Id = 7, Name = "Buick", Country = "USA" });
            this.Add(new Manufacturer { Id = 8, Name = "Ford", Country = "USA" });
            this.Add(new Manufacturer { Id = 9, Name = "Lincoln", Country = "USA" });
            this.Add(new Manufacturer { Id = 10, Name = "Dodge", Country = "USA" });
            this.Add(new Manufacturer { Id = 11, Name = "Jeep", Country = "USA" });
            this.Add(new Manufacturer { Id = 12, Name = "Tesla motors", Country = "USA" });
            this.Add(new Manufacturer { Id = 13, Name = "Bentley", Country = "UK" });
            this.Add(new Manufacturer { Id = 14, Name = "Jaguar", Country = "UK" });
            this.Add(new Manufacturer { Id = 15, Name = "Land Rover", Country = "UK" });
        }
    }
}
