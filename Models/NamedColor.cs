using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarsShop.Models
{
    class NamedColor : IEquatable<NamedColor>
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        #region IEquatable<Manufacturer>
        public bool Equals(NamedColor other)
        {
            return Name == other.Name && Color == other.Color;
        }
        #endregion
    }
}
