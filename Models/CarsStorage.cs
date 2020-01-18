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
                Color = new NamedColor { Color = Colors.Red, Name = "Red" },
                Price = 50000
            });
            this.Add(new Car
            {
                Model = "Audi R8",
                Class = "S",
                Color = new NamedColor { Color = Colors.White, Name = "White" },
                Price = 100000
            });
            this.Add(new Car
            {
                Model = "Porsche Panamera",
                Class = "S",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Price = 90000
            });
            this.Add(new Car
            {
                Model = "Volkswagen Passat",
                Class = "C",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Manufacturer = new Manufacturer { Country = "Germany", Name = "Volkswagen" },
                Price = 10000
            });
            this.Add(new Car
            {
                Model = "Chevrolet Volt",
                Class = "C",
                Color = new NamedColor { Color = Colors.White, Name = "White" },
                Price = 10000
            });
            this.Add(new Car
            {
                Model = "Cadillac Escalade",
                Class = "F",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Price = 45000
            });
            this.Add(new Car
            {
                Model = "Buick Regal",
                Class = "D",
                Color = new NamedColor { Color = Colors.DarkGray, Name = "DarkGray" },
                Price = 39500
            });
            this.Add(new Car
            {
                Model = "Ford Focus",
                Class = "C",
                Color = new NamedColor { Color = Colors.DarkBlue, Name = "DarkBlue" },
                Price = 7000
            });
            this.Add(new Car
            {
                Model = "Lincoln Navigator",
                Class = "J",
                Color = new NamedColor { Color = Colors.White, Name = "White" },
                Price = 130000
            });
            this.Add(new Car
            {
                Model = "Dodge Challenger",
                Class = "D",
                Color = new NamedColor { Color = Colors.Red, Name = "Red" },
                Price = 25000
            });
            this.Add(new Car
            {
                Model = "Jeep Compass",
                Class = "J",
                Color = new NamedColor { Color = Colors.Red, Name = "Red" },
                Price = 10000
            });
            this.Add(new Car
            {
                Model = "Tesla Model S",
                Class = "S",
                Color = new NamedColor { Color = Colors.Gray, Name = "Gray" },
                Price = 30000
            });
            this.Add(new Car
            {
                Model = "Bentley Continental",
                Class = "S",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Price = 100000
            });
            this.Add(new Car
            {
                Model = "Jaguar I-Pace",
                Class = "S",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Price = 70000
            });
        }
    }
}
