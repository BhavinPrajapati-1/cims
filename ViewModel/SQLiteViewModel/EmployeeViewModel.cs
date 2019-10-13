using Caliburn.Micro;
using CIMS.Model;
using CIMS.ViewModel.DatabaseConnection.CRUD;

namespace CIMS.ViewModel
{
    public class EmployeeViewModel : PropertyChangeHandler
    {
        public EmployeeViewModel()
        {
            Employees = new BindableCollection<Employee>(Read.Employees());
            EmployeePosition = new BindableCollection<string>(Read.Dropdown("EmployeePosition"));
        }
        public BindableCollection<Employee> Employees { get; set; }
        public BindableCollection<string> EmployeePosition { get; set; }
    }
}
