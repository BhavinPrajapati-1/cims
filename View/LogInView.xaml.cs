using CIMS.ViewModel.DBConnection;
using System.Data;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Controls;
using CIMS.Model;
using System;

namespace CIMS.View
{
    public partial class LogInView : UserControl
    {
        private readonly MainWindow main = (MainWindow)Application.Current.MainWindow;
        private readonly DataQuery query = new DataQuery();
        private DataTable thisUser = new DataTable();
        public LogInView()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.userID.Text == "" && this.password.Password.ToString() == "")
                return;
            thisUser = query.CurrentUser(this.userID.Text, this.password.Password);
            if (thisUser == null || thisUser.Rows.Count == 0)
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
            SetUser();
            main.ChangeFormSize(900, 1600);
            this.logInMessage.Visibility = Visibility.Hidden;
            main.homeButton.Visibility = Visibility.Visible;
            main.profileButton.Visibility = Visibility.Visible;
            main.SelectTab("home");
            PromptSuccesfulLogIn();
        }
        private async void PromptSuccesfulLogIn()
        {
            await main.ShowMessageAsync("Welcome! " + main.viewModel.CurrentUser.Name, "You are now signed in.");
        }

        private void SetUser()
        {
            User user = new User();
            user.ID = Convert.ToInt32(thisUser.Rows[0][0].ToString());
            user.Name = thisUser.Rows[0][1].ToString();
            //user.LogIn = this.userID.Text;
            user.Password = this.password.Password;
            //user.AccessType = thisUser.Rows[0][3].ToString();
            main.viewModel.CurrentUser = user;
            
        }

    }
}
