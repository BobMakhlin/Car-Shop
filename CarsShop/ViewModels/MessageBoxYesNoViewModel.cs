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

using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarsShop.ViewModels
{
    class MessageBoxYesNoViewModel : INotifyPropertyChanged
    {
        #region Private Definition
        private string message;
        private string caption;
        private bool? windowResult;
        #endregion

        public MessageBoxYesNoViewModel(string msg, string caption = "")
        {
            InitCommands();

            Message = msg;
            Caption = caption;
        }

        public string Message
        {
            get => message;
            set
            {
                message = value;
                INotifyPropertyChanged();
            }
        }
        public string Caption
        {
            get => caption;
            set
            {
                caption = value;
                INotifyPropertyChanged();
            }
        }
        public bool? WindowResult
        {
            get => windowResult;
            set
            {
                windowResult = value;
                INotifyPropertyChanged();
            }
        }
        public ICommand CommandYes { get; set; }
        public ICommand CommandNo { get; set; }

        void InitCommands()
        {
            CommandYes = new RelayCommand(YesClicked);
            CommandNo = new RelayCommand(NoClicked);
        }

        private void YesClicked()
        {
            WindowResult = true;
        }
        private void NoClicked()
        {
            WindowResult = false;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void INotifyPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
