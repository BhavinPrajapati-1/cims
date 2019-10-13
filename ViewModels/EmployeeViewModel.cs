

using Caliburn.Micro;
using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;

namespace CIMS.ViewModels
{
    public class EmployeeViewModel : Screen
    {
        private BindableCollection<EmployeeModel> _employees = new BindableCollection<EmployeeModel>();
        private BindableCollection<string> _positionList = new BindableCollection<string>();
        private EmployeeModel _selectedEmployee;
        private EmployeeModel _currentEmployee;
        public EmployeeViewModel()
        {
            Employees = new BindableCollection<EmployeeModel>(Read.Employees());
            PositionList = new BindableCollection<string>(Read.Dropdown("EmployeePosition"));
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
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                NotifyOfPropertyChange(() => SelectedEmployee);
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
        public BindableCollection<string> PositionList
        {
            get
            {
                return _positionList;
            }
            set
            {
                _positionList = value;
            }
        }

        //private string _lastName;
        //private string _firstName;
        //private string _middleName;
        //private int _positionID;
        //private string _contactNumber;
        //private string _emailAddress;
        //public string LastName
        //{
        //    get
        //    {
        //        return _lastName;
        //    }
        //    set
        //    {
        //        _lastName = value;
        //        NotifyOfPropertyChange(() => LastName);
        //    }
        //}
        //public string FirstName
        //{
        //    get
        //    {
        //        return _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;
        //        NotifyOfPropertyChange(() => FirstName);
        //    }
        //}
        //public string MiddleName
        //{
        //    get
        //    {
        //        return _middleName;
        //    }
        //    set
        //    {
        //        _middleName = value;
        //        NotifyOfPropertyChange(() => MiddleName);
        //    }
        //}
        //public int Position_ID
        //{
        //    get
        //    {
        //        return _positionID;
        //    }
        //    set
        //    {
        //        _positionID = value;
        //        NotifyOfPropertyChange(() => Position_ID);
        //    }
        //}
        //public string ContactNumber
        //{
        //    get
        //    {
        //        return _contactNumber;
        //    }
        //    set
        //    {
        //        _contactNumber = value;
        //        NotifyOfPropertyChange(() => ContactNumber);
        //    }
        //}
        //public string EmailAddress
        //{
        //    get
        //    {
        //        return _emailAddress;
        //    }
        //    set
        //    {
        //        _emailAddress = value;
        //        NotifyOfPropertyChange(() => EmailAddress);
        //    }
        //}
    }
}
