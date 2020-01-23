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

using CarsShop.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarsShop.Services
{
    class DialogService : IDialogService
    {
        #region Private Definitions
        OpenFileDialog openFileDialog = new OpenFileDialog();
        #endregion

        public string File { get; set; }

        public DialogResult MessageBoxYesNo(string msg, string caption = "")
        {
            var result = MessageBox.Show(msg, caption, MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                return DialogResult.Yes;
            }
            return DialogResult.No;
        }
        public DialogResult CustomMessageBoxYesNo(string msg, string caption = "")
        {
            var dialog = new MessageBoxYesNo(msg, caption);
            var result = dialog.ShowDialog();

            if (result == true)
            {
                return DialogResult.Yes;
            }
            return DialogResult.No;
        }

        public bool OpenFileDialog()
        {
            if(openFileDialog.ShowDialog() == true)
            {
                File = openFileDialog.FileName;
                return true;
            }
            return false;
        }
    }
}
