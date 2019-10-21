using Caliburn.Micro;
using CIMS.Models;
using CIMS.Models.Validators;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.ViewModels.HelperClasses;
using FluentValidation.Results;
using System;
using System.Linq;
using System.Windows;

namespace CIMS.ViewModels
{
    public class EmployeeViewModel : Screen
    {
        private EmployeeHelperClass helper;

        public EmployeeViewModel()
        {
            Employees = new BindableCollection<EmployeeModel>(Read.Employees());
            Positions = new BindableCollection<string>(Read.Dropdown("EmployeePosition"));
            universalHelper = new UniversalHelper();
        }

        //-----VM Methods

        public void ClearFields() 
        {
            FirstName = "";
            MiddleName = "";
            LastName = "";
            ContactNumber = "";
            EmailAddress = "";
            SelectedPosition = null;
            Employees = new BindableCollection<EmployeeModel>(Read.Employees());
            SelectedEmployee = new EmployeeModel();
        }

        public void RefreshTable()
        {
            ClearFields();
        }

        public void SaveData() 
        {
            EmployeeModel currentData = new EmployeeModel();
            CollectDetails(currentData);
            EmployeeValidator validator = new EmployeeValidator();
            ValidationResult result = validator.Validate(currentData);
            if (result.IsValid == false)
            {
                string errorMessage = (String.Join(Environment.NewLine + "- ",
                 result.Errors.Select(error => error.ErrorMessage)));
                universalHelper.MessageDialog("Saving of data failed!", "-" + errorMessage);
                return;
            }
            else
            {
                helper.SaveItem(currentData);
                ClearFields();
            }
        }

        private void CollectDetails(EmployeeModel currentData)
        {
            int positionID = Read.DropdownID("EmployeePosition", SelectedPosition).FirstOrDefault();
            currentData.FirstName = FirstName;
            currentData.MiddleName = MiddleName;
            currentData.LastName = LastName;
            currentData.EmailAddress = EmailAddress;
            currentData.ContactNumber = ContactNumber;
            currentData.PositionName = SelectedPosition;
            currentData.Position_ID = positionID;
        }

        public void DeleteData() 
        {
            if (!helper.CanDelete()) return;
            string message = "Are you sure you want to delete " + SelectedEmployee.FullName + "?";
            universalHelper.YesNoDialog(message, "");
            Delete.Employee(SelectedEmployee);
            ClearFields();
        }

        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
        //-----VM Properties

        private BindableCollection<EmployeeModel> _employees = new BindableCollection<EmployeeModel>();
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

        private EmployeeModel _selectedEmployee = new EmployeeModel();
        public EmployeeModel SelectedEmployee
        {
            get
            {
                if (_selectedEmployee != null)
                    helper = new EmployeeHelperClass(_selectedEmployee, this);
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                NotifyOfPropertyChange(() => SelectedEmployee);
            }
        }

        private BindableCollection<string> _positions = new BindableCollection<string>();
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

        private UniversalHelper universalHelper;
        private string _selectedPosition;
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
                _positionId = Read.DropdownID("EmployeePosition", SelectedPosition).FirstOrDefault();
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
    }
}
