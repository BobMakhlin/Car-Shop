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
