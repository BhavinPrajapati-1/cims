using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;

namespace CIMS.View
{
    public partial class HomeView : UserControl
    {
        private MainWindow main = (MainWindow)Application.Current.MainWindow;
        public HomeView()
        {
            InitializeComponent();
            //main = (MainForm)Application.Current.MainWindow;//Window.GetWindow();
        }
        private void TileEmployee_Click(object sender, RoutedEventArgs e)
        {
            //var main = Window.GetWindow(Application.Current.MainWindow);//Application.Current.MainWindow;
            EmployeeView employee = new EmployeeView();
            main.employee = employee;
            main.employee.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }   

        private void TileSupplier_Click(object sender, RoutedEventArgs e)
        {
            var main = (MainWindow)Application.Current.MainWindow;
            SupplierView supplier = new SupplierView();
            main.supplier = supplier;
            main.supplier.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }

        private void TileUnits_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }

        private void TileProduct_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }

        private void TileBOM_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }

        private void TileTransaction_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }

        private void TileReports_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }

        private void TileDatabase_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }
    }
}
