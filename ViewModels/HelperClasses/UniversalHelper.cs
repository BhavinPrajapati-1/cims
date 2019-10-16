using CIMS.Views;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;

namespace CIMS.ViewModels.HelperClasses
{
    public class UniversalHelper
    {
        private MainWindowView main = (MainWindowView)Application.Current.MainWindow;

        public async void MessageDialog(string largeText, string smalltext)
        {
            await main.ShowMessageAsync(largeText, smalltext);
        }

        public async void YesNoDialog(string largeText, string smalltext)
        {
            await main.ShowMessageAsync(largeText, smalltext);
        }
    }
}