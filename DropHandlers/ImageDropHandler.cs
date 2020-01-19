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
