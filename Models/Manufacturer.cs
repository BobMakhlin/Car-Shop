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
    class Manufacturer : IEquatable<Manufacturer>, INotifyPropertyChanged
    {
        #region Private Definitions
        private string name = "Unknown";
        private string country = "Unknown";
        #endregion

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
        public event PropertyChangedEventHandler PropertyChanged;

        void INotifyPropertyChanged([CallerMemberName] string prop = "")
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
