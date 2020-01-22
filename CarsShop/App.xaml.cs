using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CarsShop.Resources.Localization;
using LocalizatorHelper;

namespace CarsShop
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ResourceManagerService.RegisterManager("Language", Language.ResourceManager, true);
        }
    }
}
