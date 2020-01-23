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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.AppData
{
    static class AppFiles
    {
        public static string StandartImagesPath => @"AppData\Images\Standart";
        public static string CustomImagesPath => @"AppData\Images\Custom";
        public static string CarsPath => @"AppData\cars.bin";
        public static string ManufacturersPath => @"AppData\manufacturers.bin";
        public static string ThemesPath => "Resources/Themes";
        public static string LicensePath => @"AppData\LICENSE";
    }
}
