using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarsShop.Models
{
    class ColorsStorage : List<Colors>
    {
        public ColorsStorage()
        {
            var props = typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static);
            foreach (var prop in props)
            {
                this.Add((Colors)prop.GetValue(null));
            }
        }
    }
}
