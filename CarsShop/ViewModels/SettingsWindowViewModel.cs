using CarsShop.Helpers;
using CarsShop.Infrastructure;
using GalaSoft.MvvmLight.Command;
using PhotoAlbum.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarsShop.ViewModels
{
    class SettingsWindowViewModel
    {
        public SettingsWindowViewModel()
        {
            InitCommands();

            ThemesNames = ThemeManager.GetThemesNames();
            SelectedTheme = ThemesNames.FirstOrDefault();
        }

        public List<string> ThemesNames { get; set; }
        public string SelectedTheme { get; set; }
        public ICommand CommandSetTheme { get; private set; }

        void InitCommands()
        {
            CommandSetTheme = new RelayCommand<IClosable>(SetTheme);
        }

        private void SetTheme(IClosable window)
        {
            ThemeManager.SetAppTheme(SelectedTheme);
            window.Close();
        }
    }
}
