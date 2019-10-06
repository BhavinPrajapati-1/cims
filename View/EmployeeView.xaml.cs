using CIMS.ViewModel;
using CIMS.ViewModel.DBConnection;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace CIMS.View
{
    public partial class EmployeeView : UserControl
    {
        private readonly MainWindow main = (MainWindow)Application.Current.MainWindow;
        public EmployeeViewModel employeeVM;
        
        public EmployeeView()
        {
            InitializeComponent();
            employeeVM = new EmployeeViewModel();
            this.DataContext = employeeVM;
        }

    }
}
