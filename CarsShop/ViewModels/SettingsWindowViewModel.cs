using CarsShop.AppData;
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

            try
            {
                SelectedTheme = ThemeManager.LoadThemeName(AppFiles.ThemeNamePath);
            }
            catch (Exception)
            {
                SelectedTheme = ThemesNames.FirstOrDefault();
            }
        }

        public List<string> ThemesNames { get; set; }
        public string SelectedTheme { get; set; }
        public ICommand CommandSetTheme { get; private set; }
        public ICommand CommandWindowClosing { get; private set; }

        void InitCommands()
        {
            CommandSetTheme = new RelayCommand<IClosable>(SetTheme);
            CommandWindowClosing = new RelayCommand(OnWindowClosing);
        }

        private void SetTheme(IClosable window)
        {
            ThemeManager.SetAppTheme(SelectedTheme);
            window.Close();
        }
        private void OnWindowClosing()
        {
            ThemeManager.SaveThemeName(AppFiles.ThemeNamePath, SelectedTheme);
        }
    }
}
