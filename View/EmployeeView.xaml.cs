using CIMS.ViewModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace CIMS.View
{
    public partial class EmployeeView : UserControl
    {
        private readonly MainWindow main = (MainWindow)Application.Current.MainWindow;
        public EmployeeViewModel employeeVM = new EmployeeViewModel();

        public EmployeeView()
        {
            InitializeComponent();
            this.DataContext = employeeVM;
            dgEmployees.ItemsSource = employeeVM.Employees;
        }

    }
}
