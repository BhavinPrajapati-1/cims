using CIMS.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace CIMS.ViewModel
{
    public class EmployeeViewModel : PropertyChangeHandler
    {
        private DataTable _employees;
        private Employee _employee;
        
        public EmployeeViewModel()
        {
        }

        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                if (value == _employees) return;
                _employees = value;
                OnPropertyChanged("Employees");
            }
        }

        public Employee Employee
        {
            get
            {
                return Employee;
            }
            set
            {
                if (value == Employee) return;
                Employee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }
        
    }
}
