using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarsShop.Models
{
    class CarsStorage : ObservableCollection<Car>
    {
        public CarsStorage()
        {
            this.Add(new Car
            {
                Model = "BMW i8",
                Class = "S",
                Color = Colors.Red,
                Manufacturer = new Manufacturer { Country = "Germany", Name = "BMW" },
                Price = 50000
            });
            this.Add(new Car
            {
                Model = "Audi R8",
                Class = "S",
                Color = Colors.White,
                Manufacturer = new Manufacturer { Country = "Germany", Name = "Audi" },
                Price = 100000
            });
            this.Add(new Car
            {
                Model = "Porsche Panamera",
                Class = "S",
                Color = Colors.Black,
                Manufacturer = new Manufacturer { Country = "Germany", Name = "Porsche" },
                Price = 90000
            });
            this.Add(new Car
            {
                Model = "Volkswagen Passat",
                Class = "C",
                Color = Colors.Black,
                Manufacturer = new Manufacturer { Country = "Germany", Name = "Volkswagen" },
                Price = 10000
            });
            this.Add(new Car
            {
                Model = "Chevrolet Volt",
                Class = "C",
                Color = Colors.White,
                Manufacturer = new Manufacturer { Country = "USA", Name = "Chevrolet" },
                Price = 10000
            });
            this.Add(new Car
            {
                Model = "Cadillac Escalade",
                Class = "F",
                Color = Colors.Black,
                Manufacturer = new Manufacturer { Country = "USA", Name = "Cadillac" },
                Price = 45000
            });
            this.Add(new Car
            {
                Model = "Buick Regal",
                Class = "D",
                Color = Colors.DarkGray,
                Manufacturer = new Manufacturer { Country = "USA", Name = "Buick" },
                Price = 39500
            });
            this.Add(new Car
            {
                Model = "Ford Focus",
                Class = "C",
                Color = Colors.DarkBlue,
                Manufacturer = new Manufacturer { Country = "USA", Name = "Ford" },
                Price = 7000
            });
            this.Add(new Car
            {
                Model = "Lincoln Navigator",
                Class = "J",
                Color = Colors.White,
                Manufacturer = new Manufacturer { Country = "USA", Name = "Lincoln" },
                Price = 130000
            });
            this.Add(new Car
            {
                Model = "Dodge Challenger",
                Class = "D",
                Color = Colors.Red,
                Manufacturer = new Manufacturer { Country = "USA", Name = "Dodge" },
                Price = 25000
            });
            this.Add(new Car
            {
                Model = "Jeep Compass",
                Class = "J",
                Color = Colors.Red,
                Manufacturer = new Manufacturer { Country = "USA", Name = "Jeep" },
                Price = 10000
            });
            this.Add(new Car
            {
                Model = "Tesla Model S",
                Class = "S",
                Color = Colors.Gray,
                Manufacturer = new Manufacturer { Country = "USA", Name = "Tesla motors" },
                Price = 30000
            });
            this.Add(new Car
            {
                Model = "Bentley Continental",
                Class = "S",
                Color = Colors.Black,
                Manufacturer = new Manufacturer { Country = "UK", Name = "Bentley" },
                Price = 100000
            });
            this.Add(new Car
            {
                Model = "Jaguar I-Pace",
                Class = "S",
                Color = Colors.Black,
                Manufacturer = new Manufacturer { Country = "UK", Name = "Jaguar" },
                Price = 70000
            });
        }
    }
}
