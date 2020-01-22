using CarsShop.Services.WindowServices;
using CarsShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Infrastructure.WindowServices.SettingsService
{
    class SettingsWindowService : IWindowService
    {
        public void ShowDialog()
        {
            var window = new SettingsWindow();
            window.ShowDialog();
        }
    }
}
