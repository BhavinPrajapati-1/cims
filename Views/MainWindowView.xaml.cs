using Caliburn.Micro;
using CIMS.ViewModels;
using MahApps.Metro.Controls;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace CIMS.Views
{
    public partial class MainWindowView : MetroWindow
    {

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            base.OnRenderSizeChanged(sizeInfo);
            if (sizeInfo.NewSize.Width == 600) return;
            if ( sizeInfo.HeightChanged)
                this.Top += (sizeInfo.NewSize.Height - sizeInfo.PreviousSize.Height) / 64;
            if (sizeInfo.WidthChanged)
                this.Left += (sizeInfo.NewSize.Width - sizeInfo.PreviousSize.Width) / 32;
        }
    }

}

