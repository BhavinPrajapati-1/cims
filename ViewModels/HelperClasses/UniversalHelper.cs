using CIMS.Views;
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Forms;
using Application = System.Windows.Application;

namespace CIMS.ViewModels.HelperClasses
{
    public class UniversalHelper
    {
        private MainWindowView main = (MainWindowView)Application.Current.MainWindow;

        public async void MessageDialog(string largeText, string smalltext)
        {
            await main.ShowMessageAsync(largeText, smalltext);
        }
        
        public bool HasAgreed(string message, string title)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(message, title, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dialogResult == DialogResult.Yes ? true : false;
        }

    }
}