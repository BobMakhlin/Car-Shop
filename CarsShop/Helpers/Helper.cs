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

using CarsShop;
using CarsShop.AppData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PhotoAlbum.Helpers
{
    static class Helper
    {
        public static string CopyToImageDir(string file)
        {
            var filename = Path.GetFileNameWithoutExtension(file);
            var extension = Path.GetExtension(file);
            var resultFile = $"{AppFiles.CustomImagesPath}\\{filename}-{Guid.NewGuid()}{extension}";
            File.Copy(file, resultFile);

            return resultFile;
        }
    }
}
