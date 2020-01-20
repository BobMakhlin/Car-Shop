using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarsShop.Models
{
    [Serializable]
    class NamedColor : IEquatable<NamedColor>, ISerializable
    {
        public NamedColor()
        {

        }

        public string Name { get; set; }
        public Color Color { get; set; }

        #region IEquatable<Manufacturer>
        public bool Equals(NamedColor other)
        {
            return Name == other.Name && Color == other.Color;
        }
        #endregion

        #region ISerializable
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("ColorA", Color.A);
            info.AddValue("ColorR", Color.R);
            info.AddValue("ColorG", Color.G);
            info.AddValue("ColorB", Color.B);
        }

        NamedColor(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Color = new Color
            {
                A = info.GetByte("ColorA"),
                R = info.GetByte("ColorR"),
                G = info.GetByte("ColorG"),
                B = info.GetByte("ColorB")
            };
        }
        #endregion
    }
}
