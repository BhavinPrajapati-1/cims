using CIMS.View;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;

namespace CIMS
{
    public partial class MainWindow : MetroWindow {
        public EmployeeView employee;
        public SupplierView supplier;
        public MainWindow()
        {
            InitializeComponent();
            employee = new EmployeeView();
            supplier = new SupplierView();
        }

        private async void PromptSuccesfulLogIn()
        {
            await this.ShowMessageAsync("Welcome!", "You are now signed in.");
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PromptSuccesfulLogIn();
        }
    }
}
