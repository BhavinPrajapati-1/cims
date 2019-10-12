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
        public Dropdown dropdown;
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
            dropdown = new Dropdown
            {
                EmployeePosition = Read.DropdownValue("EmployeePosition"),
                InventoryClass1 = Read.DropdownValue("InventoryClass1"),
                InventoryClass2 = Read.DropdownValue("InventoryClass2"),
                InventoryQuantityType = Read.DropdownValue("InventoryQuantityType"),
                UnitStatus = Read.DropdownValue("UnitStatus"),
                UnitType = Read.DropdownValue("UnitType"),
                UserAccessType = Read.DropdownValue("UserAccessType")
            };
        }

    }

}

