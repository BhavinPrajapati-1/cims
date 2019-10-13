using Caliburn.Micro;
using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;

namespace CIMS.ViewModels
{
    public class LogInViewModel:Screen
    {
        private BindableCollection<UserModel> _users = new BindableCollection<UserModel>();
        private BindableCollection<string> _accesTypeList = new BindableCollection<string>();
        private UserModel _currentUser;
        private EmployeeModel _currentEmployee;
        private string _logInErrorMessage;
        public LogInViewModel()
        {
            Users = new BindableCollection<UserModel>(Read.Users());
            AccessTypeList = new BindableCollection<string>((Read.Dropdown("EmployeeAccessType")))
        }
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
        public BindableCollection<string> AccessTypeList
        {
            get
            {
                return _accesTypeList;
            }
            set
            {
                _accesTypeList = value;
                NotifyOfPropertyChange(() => AccessTypeList);
            }
        }
        public EmployeeModel CurrentEmployee
        {
            get
            {
                return _currentEmployee;
            }
            set
            {
                _currentEmployee = value;
                NotifyOfPropertyChange(() => CurrentEmployee);
            }
        }
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
            }

        }
        private bool IsLogInClicked()
        {
            if (CurrentUser==null)
            {
                LogInErrorMessage = "Incorrect username or password.";
                CurrentUser.Name = "";
                CurrentUser.Password = "";
            }
            else
            {

            }
        }
        public void LogIn()
        {

        }
    }
}
