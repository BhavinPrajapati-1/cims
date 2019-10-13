using System.Data;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Controls;
using CIMS.Model;
using System;
using System.Collections.Generic;
using CIMS.ViewModel.DatabaseConnection.CRUD;
using System.Linq;

namespace CIMS.View
{
    public partial class LogInView : UserControl
    {
        private readonly MainWindow main;
        private List<User> users;
        private User user;
        public LogInView()
        {
            main = (MainWindow)Application.Current.MainWindow;
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.userID.Text == "" && this.password.Password == "")
                return;
            users = Read.Users();
            user = users.Where(u => u.Name == this.userID.Text ||
                u.Password == this.password.Password).FirstOrDefault();
            if (user == null)
            {
                ShowInvalidLogIn();
                return;
            }
            LaunchHomeScreen();
        }
        private void ShowInvalidLogIn()
        {
            this.logInMessage.Visibility = Visibility.Visible;
            this.userID.Text = "";
            this.password.Password = "";
        }
        private void LaunchHomeScreen()
        {
            //user = Read.User(user.ID);
            main.viewModel.CurrentUser = user;
            main.ChangeFormSize(900, 1600);
            this.logInMessage.Visibility = Visibility.Hidden;
            main.homeButton.Visibility = Visibility.Visible;
            main.profileButton.Visibility = Visibility.Visible;
            main.SelectTab("home");
            PromptSuccesfulLogIn();
        }
        private async void PromptSuccesfulLogIn()
        {
            await main.ShowMessageAsync("Welcome! " + main.viewModel.CurrentUser.EmployeeFullName, "You are now signed in.");
        }
    }
}
