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
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Class { get; set; }
        public Color Color { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ObservableCollection<Photo> Photos { get; set; }
    }
}
