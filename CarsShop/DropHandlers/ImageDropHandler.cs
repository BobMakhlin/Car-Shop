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

using CarsShop.Models;
using CarsShop.ViewModels;
using GongSolutions.Wpf.DragDrop;
using PhotoAlbum.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarsShop.DropHandlers
{
    class ImageDropHandler : IDropTarget
    {
        MainWindowViewModel viewModel;

        public ImageDropHandler(MainWindowViewModel vm)
        {
            viewModel = vm;
        }

        public void DragOver(IDropInfo dropInfo)
        {
            if (dropInfo.Data is DataObject obj)
            {
                dropInfo.Effects = DragDropEffects.Move;
            }
        }

        public void Drop(IDropInfo dropInfo)
        {
            if (dropInfo.Data is DataObject obj)
            {
                var files = obj.GetFileDropList();
                foreach (var file in files)
                {
                    if (!FileFormat.IsImage(file))
                        return;

                    var filename = Helper.CopyToImageDir(file);
                    viewModel.CurrentCar.Photos.Add(new Photo { Path = filename });
                    viewModel.CurrentPhoto = viewModel.CurrentCar.Photos.LastOrDefault();
                }
            }
        }
    }
}
