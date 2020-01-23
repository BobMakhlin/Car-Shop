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
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarsShop.Models
{
    [Serializable]
    class Manufacturer : IEquatable<Manufacturer>, INotifyPropertyChanged
    {
        #region Private Definitions
        private string name = "Unknown";
        private string country = "Unknown";
        #endregion

        public int Id { get; set; }
        public string Name 
        { 
            get => name; 
            set
            {
                name = value;
                INotifyPropertyChanged();
            }
        }
        public string Country 
        {
            get => country;
            set
            {
                country = value;
                INotifyPropertyChanged();
            }
        }

        #region IEquatable<Manufacturer>
        public bool Equals(Manufacturer other)
        {
            return Name == other.Name && Country == other.Country;
        }
        #endregion

        #region INotifyPropertyChanged
        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        void INotifyPropertyChanged([CallerMemberName] string prop = "")
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
