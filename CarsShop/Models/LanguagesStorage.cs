using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Models
{
    class LanguagesStorage : List<CultureInfo>
    {
        public LanguagesStorage()
        {
            this.Add(new CultureInfo("ru-RU"));
            this.Add(new CultureInfo("en-US"));
            this.Add(new CultureInfo("it"));
            this.Add(new CultureInfo("fr"));
            this.Add(new CultureInfo("de"));
            this.Add(new CultureInfo("uk"));
        }
    }
}
