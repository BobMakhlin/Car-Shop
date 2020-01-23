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
