using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;

namespace CIMS
{
    public partial class LogInWindow : MetroWindow
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private async void PromptSuccesfulLogIn()
        {
            await this.ShowMessageAsync("Welcome!", "You are now signed in.");
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            //PromptSuccesfulLogIn();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }
    }
}
