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
