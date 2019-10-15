

using Caliburn.Micro;
using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.ViewModels.HelperClasses;
using CIMS.Views;
using MahApps.Metro.Controls.Dialogs;
using System.Linq;
using System.Windows;

namespace CIMS.ViewModels
{
    public class EmployeeViewModel : Screen
    {
        private BindableCollection<EmployeeModel> _employees = new BindableCollection<EmployeeModel>();
        private BindableCollection<string> _positions = new BindableCollection<string>(); 
        private EmployeeModel _selectedEmployee;
        private string _selectedPosition;
        private MainWindowView main;
        private EmployeeHelperClass helper;
        public EmployeeViewModel()
        {
            Employees = new BindableCollection<EmployeeModel>(Read.Employees());
            Positions = new BindableCollection<string>(Read.Dropdown("EmployeePosition"));
            SelectedEmployee = new EmployeeModel();
        }
        public BindableCollection<EmployeeModel> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                _employees = value;
                NotifyOfPropertyChange(() => Employees);
            }
        }
        public EmployeeModel SelectedEmployee
        {
            get
            {
                AccessHelperClass();
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                NotifyOfPropertyChange(() => SelectedEmployee);
            }
        }

        private void AccessHelperClass()
        {
            if (_selectedEmployee != null)
                helper = new EmployeeHelperClass(_selectedEmployee, this);
        }

        public BindableCollection<string> Positions
        {
            get
            {
                return _positions;
            }
            set
            {
                _positions = value;
                NotifyOfPropertyChange(() => Positions);
            }
        }
        public string SelectedPosition
        {
            get
            {
                return _selectedPosition;
            }
            set
            {
                _selectedPosition = value;
                NotifyOfPropertyChange(() => PositionId);
                NotifyOfPropertyChange(() => SelectedPosition);
            }
        }
        private int _positionId;
        public int PositionId
        {
            get
            {
                _positionId =Read.DropdownID("EmployeePosition", SelectedPosition).FirstOrDefault();
                return _positionId;
            }
            set
            {
                _positionId = value;
                NotifyOfPropertyChange(() => PositionId);
                NotifyOfPropertyChange(() => SelectedPosition);
            }
        }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
            }
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
            }
        }
        private string _middleName;
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
                NotifyOfPropertyChange(() => MiddleName);
            }
        }
        private string _contactNumber;
        public string ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
                NotifyOfPropertyChange(() => ContactNumber);
            }
        }
        private string _emailAddress;
        public string EmailAddress
        {
            get
            {
                return _emailAddress;
            }
            set
            {
                _emailAddress = value;
                NotifyOfPropertyChange(() => EmailAddress);
            }
        }

        public void AddEmployee()
        {
            int positionID = Read.DropdownID("EmployeePosition", SelectedPosition).FirstOrDefault();
            EmployeeModel currentEmployee = new EmployeeModel();
            currentEmployee.FirstName = FirstName;
            currentEmployee.MiddleName = MiddleName;
            currentEmployee.LastName = LastName;
            currentEmployee.EmailAddress = EmailAddress;
            currentEmployee.ContactNumber = ContactNumber;
            currentEmployee.PositionName = SelectedPosition;
            currentEmployee.Position_ID = positionID;
            helper.SaveEmployee(currentEmployee);
            ClearEmployeeFields();
        }


        public void DeleteEmployee()
        {
            //promp message
            Delete.Employee(SelectedEmployee);
            RefreshTable();
        }

        public void ClearEmployeeFields()
        {
            FirstName = "";
            MiddleName = "";
            LastName = "";
            ContactNumber = "";
            EmailAddress = "";
            SelectedPosition = null;
            RefreshTable();
        }

        public void RefreshTable()
        {
            SelectedEmployee = new EmployeeModel();
            Employees = new BindableCollection<EmployeeModel>(Read.Employees());
            Positions = new BindableCollection<string>(Read.Dropdown("EmployeePosition"));
        }

        private async void PromptMessage(string largeText, string smalltext)
        {
            main = (MainWindowView)Application.Current.MainWindow;
            await main.ShowMessageAsync(largeText, smalltext);
        }
    }
}
