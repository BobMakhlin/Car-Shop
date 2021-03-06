﻿/*
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
