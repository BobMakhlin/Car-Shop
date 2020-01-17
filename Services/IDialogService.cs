using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Services
{
    interface IDialogService
    {
        DialogResult MessageBoxYesNo(string msg, string caption = "");
    }
}
