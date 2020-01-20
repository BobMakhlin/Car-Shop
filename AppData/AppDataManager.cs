using CarsShop.Models;
using Newtonsoft.Json;
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
    }
}
