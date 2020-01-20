using CarsShop.AppData;
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
                Color = new NamedColor { Color = Colors.White, Name = "White" },
                Price = 85000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\bmw i8-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\bmw i8-2.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\bmw i8-3.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Audi R8",
                Class = "S",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Price = 100000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\audi r8-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\audi r8-2.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\audi r8-3.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Porsche Panamera",
                Class = "S",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Price = 90000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\porsche panamera-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\porsche panamera-2.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Volkswagen Passat",
                Class = "C",
                Color = new NamedColor { Color = Colors.Red, Name = "Red" },
                Price = 10000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\volkswagen passat-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\volkswagen passat-2.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\volkswagen passat-3.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Chevrolet Volt",
                Class = "C",
                Color = new NamedColor { Color = Colors.White, Name = "White" },
                Price = 10000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\chevrolet volt-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\chevrolet volt-2.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\chevrolet volt-3.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Cadillac Escalade",
                Class = "F",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Price = 45000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\cadillac escalade-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\cadillac escalade-2.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Buick Regal",
                Class = "D",
                Color = new NamedColor { Color = Colors.DarkGray, Name = "DarkGray" },
                Price = 39500,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\buick regal-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\buick regal-2.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Ford Focus",
                Class = "C",
                Color = new NamedColor { Color = Colors.DarkBlue, Name = "DarkBlue" },
                Price = 7000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\ford focus-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\ford focus-2.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\ford focus-3.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Lincoln Navigator",
                Class = "J",
                Color = new NamedColor { Color = Colors.White, Name = "White" },
                Price = 130000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\lincoln navigator-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\lincoln navigator-2.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Dodge Challenger",
                Class = "D",
                Color = new NamedColor { Color = Colors.Red, Name = "Red" },
                Price = 25000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\dodge challenger-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\dodge challenger-2.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Jeep Compass",
                Class = "J",
                Color = new NamedColor { Color = Colors.Gray, Name = "Gray" },
                Price = 10000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\jeep compass-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\jeep compass-2.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Tesla Model S",
                Class = "S",
                Color = new NamedColor { Color = Colors.Gray, Name = "Gray" },
                Price = 30000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\tesla model s-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\tesla model s-2.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Bentley Continental",
                Class = "S",
                Color = new NamedColor { Color = Colors.Black, Name = "Black" },
                Price = 100000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\bentley continental-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\bentley continental-2.png" }
                }
            });
            this.Add(new Car
            {
                Model = "Jaguar I-Pace",
                Class = "S",
                Color = new NamedColor { Color = Colors.Black, Name = "DarkGray" },
                Price = 70000,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\jaguar i-pace-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\jaguar i-pace-2.png" }
                }
            });
        }
    }
}
