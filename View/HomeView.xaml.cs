using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;

namespace CIMS.View
{
    public partial class HomeView : UserControl
    {
        private MainWindow main;
        public HomeView()
        {
            InitializeComponent();
            main = (MainWindow)Application.Current.MainWindow;
        }
        private void TileEmployee_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            main.ucEmployee.Visibility = Visibility.Visible;
        }   

        private void TileSupplier_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            main.ucSupplier.Visibility = Visibility.Visible;
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
