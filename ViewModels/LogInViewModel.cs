using Caliburn.Micro;
using CIMS.Models;
using CIMS.Views;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using MahApps.Metro.Controls.Dialogs;
using System.Linq;
using System.Windows;

namespace CIMS.ViewModels
{
    public class LogInViewModel : Screen
    {
        MainWindowView main;

        public LogInViewModel()
        {
            Users = new BindableCollection<UserModel>(Read.Users());
        }

        private BindableCollection<UserModel> _users = new BindableCollection<UserModel>();
        public BindableCollection<UserModel> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                NotifyOfPropertyChange(() => Users);
            }
        }

        private UserModel _currentUser = new UserModel();
        public UserModel CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
                NotifyOfPropertyChange(() => CurrentUser);
            }

        }

        private string _logInErrorMessage;
        public string LogInErrorMessage
        {
            get
            {
                return _logInErrorMessage;
            }
            set
            {
                _logInErrorMessage = value;
                NotifyOfPropertyChange(() => LogInErrorMessage);
                NotifyOfPropertyChange(() => LogInSuccessful);
            }

        }

        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }

        }

        private string _userPassword;
        public string UserPassword
        {
            get
            {
                return _userPassword;
            }
            set
            {
                _userPassword = value;
                NotifyOfPropertyChange(() => UserPassword);
                NotifyOfPropertyChange(() => CanLogIn);
            }

        }

        public bool CanLogIn
        {
            get
            {
                bool output = (!string.IsNullOrWhiteSpace(UserName) &&
                    !string.IsNullOrWhiteSpace(UserPassword));
                return output;
            }
        }

        private bool _logInSuccessful;
        public bool LogInSuccessful
        {
            get
            {
                return _logInSuccessful;
            }
            set
            {
                _logInSuccessful = value;
                NotifyOfPropertyChange(() => LogInSuccessful);
            }
        }

        public void LogIn(string userName, string userPassword)
        {
            CurrentUser = new UserModel();
            CurrentUser = Users.Where(u => u.Name == UserName &&
                 u.Password == UserPassword).FirstOrDefault();
            if (CurrentUser == null)
            {
                UserName = "";
                UserPassword = "";
                LogInErrorMessage = "User ID or password entered is incorrect.";
                LogInSuccessful = false;
                return;
            }
            else
            {
                main = (MainWindowView)Application.Current.MainWindow;
                main.Height = 900; main.Width = 1600;
                LoadHome();
                PromptSuccesfulLogIn();
                LogInErrorMessage = "";
                LogInSuccessful = true;

            }
        }

        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }

        private async void PromptSuccesfulLogIn()
        {
            await main.ShowMessageAsync("Welcome! " + CurrentUser.EmployeeFullName, "You are now signed in.");
            main.lblEmployeeFullName.Content = CurrentUser.EmployeeFullName;
            main.lblAccessTypeName.Content = CurrentUser.AccessTypeName;
            main.lblEmployeeID.Content = CurrentUser.Employee_ID;
        }
    }
}
