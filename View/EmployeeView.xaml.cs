using CIMS.ViewModel.DBConnection;
using System.Data;
using System.Windows.Controls;

namespace CIMS.View
{
    public partial class EmployeeView : UserControl
    {
        private DataQuery dataQuery = new DataQuery();
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void UserControl_Initialized(object sender, System.EventArgs e)
        {
            //DataTable employeeTable = dataQuery.EmployeeTable();
            //employee.ItemsSource = employeeTable.AsDataView();
        }
    }
}
