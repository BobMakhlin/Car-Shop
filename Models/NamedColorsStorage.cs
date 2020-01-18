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
    class NamedColorsStorage : List<NamedColor>
    {
        public NamedColorsStorage()
        {
            var props = typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static);
            foreach (var prop in props)
            {
                this.Add(new NamedColor
                {
                    Name = prop.Name,
                    Color = (Color)prop.GetValue(null)
                });
            }
        }
    }
}
