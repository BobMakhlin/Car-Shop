using CarsShop.AppData;
using CarsShop.Helpers;
using CarsShop.Infrastructure;
using CarsShop.Models;
using CarsShop.Properties;
using GalaSoft.MvvmLight.Command;
using LocalizatorHelper;
using PhotoAlbum.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarsShop.ViewModels
{
    class SettingsWindowViewModel
    {
        public SettingsWindowViewModel()
        {
            InitCommands();

            // Init theme.
            ThemesNames = ThemeManager.GetThemesNames();

            var theme = Settings.Default.Theme;
            if (theme != string.Empty)
            {
                SelectedTheme = theme;
            }
            else
            {
                SelectedTheme = ThemesNames.FirstOrDefault();
            }

            // Init language.
            Languages = new LanguagesStorage();
            SelectedLanguage = new CultureInfo(Settings.Default.Language);

            // Load license.
            License = AppDataManager.LoadLicense(AppFiles.LicensePath);
        }

        public List<string> ThemesNames { get; set; }
        public string SelectedTheme { get; set; }
        public List<CultureInfo> Languages { get; set; }
        public CultureInfo SelectedLanguage { get; set; }
        public string License { get; set; }
        public ICommand CommandOk { get; private set; }
        public ICommand CommandWindowClosing { get; private set; }

        void InitCommands()
        {
            CommandOk = new RelayCommand<IClosable>(ApplySettings);
            CommandWindowClosing = new RelayCommand(OnWindowClosing);
        }

        private void ApplySettings(IClosable window)
        {
            ThemeManager.SetAppTheme(SelectedTheme);
            ResourceManagerService.ChangeLocale(SelectedLanguage.Name);
            window.Close();
        }
        private void OnWindowClosing()
        {
            Settings.Default.Theme = SelectedTheme;
            Settings.Default.Language = SelectedLanguage.Name;
        }
    }
}
