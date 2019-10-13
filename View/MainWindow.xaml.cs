using CIMS.Model;
using CIMS.View;
using CIMS.ViewModel;
using CIMS.ViewModel.DatabaseConnection.CRUD;
using MahApps.Metro.Controls;
using System.Windows;

namespace CIMS
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindowViewModel viewModel;
        public DropdownCollection dropdown;
        public MainWindow()
        {
            viewModel = new MainWindowViewModel();
            InitializeComponent();
            FormSetUp();
        }
        
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            SelectTab("home");
        }
        public void SelectTab(string tabName)
        {
            foreach(MetroTabItem tabControl in mainTab.Items)
            {
                if (tabControl.Name == tabName)
                    tabControl.IsSelected = true;
            }
        }
        private void FormSetUp()
        {
            ChangeFormSize(600, 600);
            SetUpDropdown();
            this.homeButton.Visibility = Visibility.Hidden;
            this.profileButton.Visibility = Visibility.Hidden;
            this.DataContext = viewModel;
        }
        public void ChangeFormSize(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public void SetUpDropdown()
        {
            dropdown = new DropdownCollection
            {
                EmployeePosition = Read.Dropdown("EmployeePosition"),
                InventoryClass1 = Read.Dropdown("InventoryClass1"),
                InventoryClass2 = Read.Dropdown("InventoryClass2"),
                InventoryQuantityType = Read.Dropdown("InventoryQuantityType"),
                UnitStatus = Read.Dropdown("UnitStatus"),
                UnitType = Read.Dropdown("UnitType"),
                UserAccessType = Read.Dropdown("UserAccessType")
            };
        }

    }

}

