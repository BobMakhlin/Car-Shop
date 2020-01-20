using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarsShop.Models
{
    class ManufacturersStorage : ObservableCollection<Manufacturer>
    {
        public ManufacturersStorage()
        {
            this.Add(new Manufacturer { Name = "BMW", Country = "Germany" });
            this.Add(new Manufacturer { Name = "Audi", Country = "Germany" });
            this.Add(new Manufacturer { Name = "Porsche", Country = "Germany" });
            this.Add(new Manufacturer { Name = "Volkswagen", Country = "Germany" });
            this.Add(new Manufacturer { Name = "Chevrolet", Country = "USA" });
            this.Add(new Manufacturer { Name = "Cadillac", Country = "USA" });
            this.Add(new Manufacturer { Name = "Buick", Country = "USA" });
            this.Add(new Manufacturer { Name = "Ford", Country = "USA" });
            this.Add(new Manufacturer { Name = "Lincoln", Country = "USA" });
            this.Add(new Manufacturer { Name = "Dodge", Country = "USA" });
            this.Add(new Manufacturer { Name = "Jeep", Country = "USA" });
            this.Add(new Manufacturer { Name = "Tesla motors", Country = "USA" });
            this.Add(new Manufacturer { Name = "Bentley", Country = "UK" });
            this.Add(new Manufacturer { Name = "Jaguar", Country = "UK" });
            this.Add(new Manufacturer { Name = "Land Rover", Country = "UK" });
        }
    }
}
