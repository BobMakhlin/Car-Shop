using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarsShop.Models
{
    class Car
    {
        public string Model { get; set; } = "Unknown";
        public decimal Price { get; set; }
        public string Class { get; set; } = "Unknown";
        public Color Color { get; set; }
        public Manufacturer Manufacturer { get; set; } = new Manufacturer();
        public ObservableCollection<Photo> Photos { get; set; } = new ObservableCollection<Photo>();
    }
}
