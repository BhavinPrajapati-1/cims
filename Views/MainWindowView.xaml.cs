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

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            LogInViewModel viewModel = new LogInViewModel();
            //viewModel.LoadHome();
            var conductor = viewModel.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
    }

}

