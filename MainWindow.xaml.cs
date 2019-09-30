using CIMS.View;
using MahApps.Metro.Controls;
using System.Windows;

namespace CIMS
{
    public partial class MainWindow : MetroWindow
    {
        private HomeView homeView;
        private EmployeeView employeeView;
        public MainWindow()
        {
            InitializeComponent();
            HideAllUserControls();
        }

        private void InstantiateUserControls()
        {
            homeView = new HomeView();
            employeeView = new EmployeeView();
            homeView.Visibility = Visibility.Visible;
        }
        private void HideAllUserControls()
        {
            InstantiateUserControls();
            homeView.Visibility = Visibility.Hidden;
            employeeView.Visibility = Visibility.Hidden;
        }
        private void HomeView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
