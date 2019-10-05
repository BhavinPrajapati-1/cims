using CIMS.ViewModel.DBConnection;
using System.Data;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Controls;

namespace CIMS.View
{
    public partial class LogInView : UserControl
    {
        private DataQueryParameters queryParam = new DataQueryParameters();
        private DataTable user = new DataTable();
        private MainWindow main = (MainWindow)Application.Current.MainWindow;
        public LogInView()
        {
            InitializeComponent();
        }
        private async void PromptSuccesfulLogIn()
        {
            await main.ShowMessageAsync("Welcome!", "You are now signed in.");
        }
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.userID.Text == "" && this.password.Password.ToString() == "")
                return;
            user = queryParam.CurrentUser(this.userID.Text, this.password.Password);
            if (user == null || user.Rows.Count == 0)
            {
                this.logInMessage.Visibility = Visibility.Visible;
                this.userID.Text = "";
                this.password.Password = "";
                return;
            }
            LaunchHomeScreen();
        }

        private void LaunchHomeScreen()
        {
            main.Height = 900;
            main.Width = 1600;
            this.logInMessage.Visibility = Visibility.Hidden;
            this.Visibility = Visibility.Hidden;
            main.ucHome.Visibility = Visibility.Visible;
            PromptSuccesfulLogIn();
        }
    }
}
