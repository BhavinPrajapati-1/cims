using CIMS.View;
using MahApps.Metro.Controls;
using System.Windows;

namespace CIMS
{
    public partial class MainWindow : MetroWindow {
        public LogInView logIn;
        public HomeView home;
        public EmployeeView employee;
        public SupplierView supplier;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            //InstantiateViews();
            HideAllViews();
            ucLogIn.Visibility = Visibility.Visible;
        }

        public void InstantiateViews()
        {
            logIn = new LogInView();
            home = new HomeView();
            employee = new EmployeeView();
            supplier = new SupplierView();
        }

        public void HideAllViews()
        {
            ucLogIn.Visibility = Visibility.Hidden;
            ucHome.Visibility = Visibility.Hidden;
            ucUser.Visibility = Visibility.Hidden;
            ucEmployee.Visibility = Visibility.Hidden;
            ucSupplier.Visibility = Visibility.Hidden;
        }


        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = 600;
            this.Width = 600;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            InstantiateViews();
            HideAllViews();
        }

        private void HomeButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
