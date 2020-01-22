using CarsShop.AppData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarsShop.Helpers
{
    static class ThemeManager
    {
        public static void SetAppTheme(string themeName)
        {
            var uri = new Uri($"/{AppFiles.ThemesPath}/{themeName}/Core.xaml", UriKind.Relative);
            var theme = App.LoadComponent(uri) as ResourceDictionary;
            App.Current.Resources.MergedDictionaries.Clear();
            App.Current.Resources.MergedDictionaries.Add(theme);
        }
        public static List<string> GetThemesNames()
        {
            return new List<string>
            {
                "DarkBlue",
                "DarkOrange"
            };
        }


        public static void SaveThemeName(string path, string themeName)
        {
            using (var fs = File.Create(path))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, themeName);
            }
        }
        public static string LoadThemeName(string path)
        {
            using (var fs = File.OpenRead(path))
            {
                var bf = new BinaryFormatter();
                return (string)bf.Deserialize(fs);
            }
        }
    }
}
