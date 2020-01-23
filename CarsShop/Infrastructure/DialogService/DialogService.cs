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
