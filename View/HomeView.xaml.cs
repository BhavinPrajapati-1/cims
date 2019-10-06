using CIMS.ViewModel;
using CIMS.ViewModel.DBConnection;
using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;

namespace CIMS.View
{
    public partial class HomeView : UserControl
    {
        private MainWindow main = (MainWindow)Application.Current.MainWindow;
        private DataQuery dataQuery = new DataQuery();
        private EmployeeViewModel vmEmployee;
        //private SupplierViewModel vmSupplier;

        public HomeView()
        {
            InitializeComponent();
            main.Height = 900;
            main.Width = 1600;
        }
        private void TileEmployee_Click(object sender, RoutedEventArgs e)
        {
            main.SelectTab("employee");
            vmEmployee = main.ucEmployee.employeeVM;
            vmEmployee.EmployeeTable = dataQuery.EmployeeTable();
        }   

        private void TileSupplier_Click(object sender, RoutedEventArgs e)
        {
            main.SelectTab("supplier");
            //main.viewModel.SupplierTable = dataQuery.SupplierTable();
        }

        private void TileUnits_Click(object sender, RoutedEventArgs e)
        {
            main.SelectTab("unit");
        }

        private void TileProduct_Click(object sender, RoutedEventArgs e)
        {
            main.SelectTab("product");
        }

        private void TileBOM_Click(object sender, RoutedEventArgs e)
        {
            main.SelectTab("bom");
        }

        private void TileTransaction_Click(object sender, RoutedEventArgs e)
        {
            main.SelectTab("transaction");
        }

        private void TileReports_Click(object sender, RoutedEventArgs e)
        {
            main.SelectTab("report");
        }

        private void TileDatabase_Click(object sender, RoutedEventArgs e)
        {
            main.SelectTab("database");
        }
    }
}
