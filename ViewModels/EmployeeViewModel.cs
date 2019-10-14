

using Caliburn.Micro;
using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.Views;
using MahApps.Metro.Controls.Dialogs;
using System.Collections.Generic;
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
        MainWindowView main;
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
                EmployeeFields(_selectedEmployee);
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                NotifyOfPropertyChange(() => SelectedEmployee);
            }
        }

        private void EmployeeFields(EmployeeModel selectedEmployee)
        {
            if (selectedEmployee == null) return;
            FirstName = selectedEmployee.FirstName;
            LastName = selectedEmployee.LastName;
            MiddleName = selectedEmployee.MiddleName;
            ContactNumber = selectedEmployee.ContactNumber;
            EmailAddress = selectedEmployee.EmailAddress;
            SelectedPosition = selectedEmployee.PositionName;
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
            EmployeeModel originalEmployee = null;
            originalEmployee = Read.Employees().Where(e => e.ID == SelectedEmployee.ID).FirstOrDefault();
            EmployeeModel currentEmployee = SelectedEmployee;
            currentEmployee.FirstName = FirstName;
            currentEmployee.MiddleName = MiddleName;
            currentEmployee.LastName = LastName;
            currentEmployee.EmailAddress = EmailAddress;
            currentEmployee.ContactNumber = ContactNumber;
            currentEmployee.PositionName = SelectedPosition;
            currentEmployee.Position_ID = Read.DropdownID("EmployeePosition", SelectedPosition).FirstOrDefault(); 
            if (currentEmployee.ID== 0)
            {
                Create.Employee(SelectedEmployee);
                PromptMessage("Employee data has been added successfully!", "");
            }
            else if(currentEmployee.ID > 0 && currentEmployee != originalEmployee)
            {
                Update.Employee(SelectedEmployee);
                PromptMessage("Employee data has been updated successfully!", "");
            }
            RefreshTable();
        }

        public void UpdateEmployee()
        {

        }

        public void DeleteEmployee()
        {
            //promp message
            Delete.Employee(SelectedEmployee);
            RefreshTable();
            PromptMessage("Employee data has been deleted successfully!", "");
        }

        public void ClearEmployeeFields()
        {
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
