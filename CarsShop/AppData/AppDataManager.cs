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

using CarsShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarsShop.AppData
{
    static class AppDataManager
    {
        public static void SaveCars(string path, ObservableCollection<Car> cars)
        {
            using (var fs = File.Create(path))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, cars);
            }
        }
        public static ObservableCollection<Car> LoadCars(string path)
        {
            using (var fs = File.OpenRead(path))
            {
                var bf = new BinaryFormatter();
                return (ObservableCollection<Car>)bf.Deserialize(fs);
            }
        }
        public static void SaveManufacturers(string path, ObservableCollection<Manufacturer> manufacturers)
        {
            using (var fs = File.Create(path))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, manufacturers);
            }
        }
        public static ObservableCollection<Manufacturer> LoadManufacturers(string path)
        {
            using (var fs = File.OpenRead(path))
            {
                var bf = new BinaryFormatter();
                return (ObservableCollection<Manufacturer>)bf.Deserialize(fs);
            }
        }

        public static string LoadLicense(string licensePath) => File.ReadAllText(licensePath);
    }
}
