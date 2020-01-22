using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CarsShop.Models
{
    [Serializable]
    class Car : INotifyPropertyChanged
    {
        #region Private Definitions
        private string model = "Unknown";
        private decimal price;
        private string @class;
        private NamedColor color;
        private int manufacturerId = -1;
        #endregion

        public string Model
        { 
            get => model; 
            set
            {
                model = value;
                INotifyPropertyChanged();
            }
        }
        public decimal Price
        { 
            get => price; 
            set
            {
                price = value;
                INotifyPropertyChanged();
            }
        }
        public string Class 
        {
            get => @class;
            set
            {
                @class = value;
                INotifyPropertyChanged();
            }
        }
        public NamedColor Color 
        { 
            get => color;
            set
            {
                color = value;
                INotifyPropertyChanged();
            }
        }
        public int ManufacturerId 
        { 
            get => manufacturerId; 
            set
            {
                manufacturerId = value;
                INotifyPropertyChanged();
            }
        }

        public ObservableCollection<Photo> Photos { get; set; } = new ObservableCollection<Photo>();

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
