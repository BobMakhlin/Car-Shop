using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Services
{
    interface IDialogService
    {
        string File { get; set; }
        bool OpenFileDialog();
        DialogResult MessageBoxYesNo(string msg, string caption = "");
        DialogResult CustomMessageBoxYesNo(string msg, string caption = "");
    }
}
