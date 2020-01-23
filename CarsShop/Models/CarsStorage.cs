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
    [Serializable]
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
                ManufacturerId = 1,
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
                ManufacturerId = 2,
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
                ManufacturerId = 3,
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
                ManufacturerId = 4,
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
                ManufacturerId = 5,
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
                ManufacturerId = 6,
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
                ManufacturerId = 7,
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
                ManufacturerId = 8,
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
                ManufacturerId = 9,
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
                ManufacturerId = 10,
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
                ManufacturerId = 11,
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
                ManufacturerId = 12,
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
                ManufacturerId = 13,
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
                ManufacturerId = 14,
                Photos = new ObservableCollection<Photo>
                {
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\jaguar i-pace-1.png" },
                    new Photo { Path=$"{AppFiles.StandartImagesPath}\\jaguar i-pace-2.png" }
                }
            });
        }
    }
}
