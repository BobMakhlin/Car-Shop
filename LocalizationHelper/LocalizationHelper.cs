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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;

namespace LocalizatorHelper
{
    public class LocalizationHelper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void INotifyPropertyChanged(string propertyName)
        {
            var evt = PropertyChanged;
            evt?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Создает новый экземпляр класса LocalizationHelper.
        /// </summary>
        public LocalizationHelper()
        {
            if (!DesignHelpers.IsInDesignMode)
            {
                // Обновить все привязки при смене локали.
                ResourceManagerService.LocaleChanged += (s, e) =>
                {
                    INotifyPropertyChanged("");
                };
            }
        }

        /// <summary>
        /// Получение строки из ресурса с помощью ResourceManager.
        /// </summary>
        /// <param name="key">Ключ, который нужно извлечь из ресурсов в формате [ManagerName.ResourceKey]</param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                if (!ValidateKey(key))
                {
                    throw new ArgumentException(@"Указан не правильный формат строки. [ManagerName.ResourceKey]");
                }
                if (DesignHelpers.IsInDesignMode)
                {
                    return "[res]";
                }

                return ResourceManagerService.GetResourceString(GetManagerKey(key), GetResourceKey(key));
            }
        }

        #region Private Key Methods

        private bool ValidateKey(string input)
        {
            return input.Contains(".");
        }

        private string GetManagerKey(string input)
        {
            return input.Split('.')[0];
        }

        private string GetResourceKey(string input)
        {
            return input.Substring(input.IndexOf('.') + 1);
        }

        #endregion
    }
}


