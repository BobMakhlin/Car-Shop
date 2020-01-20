using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarsShop.Models
{
    class Car : INotifyPropertyChanged
    {
        #region Private Definitions
        private string model = "Unknown";
        private decimal price;
        private string @class;
        private NamedColor color;
        private Manufacturer manufacturer = new Manufacturer();
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
        public Manufacturer Manufacturer 
        { 
            get => manufacturer; 
            set
            {
                manufacturer = value;
                INotifyPropertyChanged();
            }
        }

        public ObservableCollection<Photo> Photos { get; set; } = new ObservableCollection<Photo>();

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
