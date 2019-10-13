using Caliburn.Micro;
using CIMS.Models;

namespace CIMS.ViewModels
{
    public class MainWindowViewModel : Conductor<object>
    {
        private UserModel _user;
        public MainWindowViewModel()
        {

        }
        public UserModel CurrentUser
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                NotifyOfPropertyChange(() => CurrentUser);
            }
        }

        public void LoadEmployee()
        {
            ActivateItem(new EmployeeViewModel());
        }
        public void LoadSupplier()
        {
            ActivateItem(new SupplierViewModel());
        }
        public void LoadUnit()
        {
            ActivateItem(new UnitViewModel());
        }
        public void LoadInventory()
        {
            ActivateItem(new InventoryViewModel());
        }
        public void LoadBillOfMaterials()
        {
            ActivateItem(new BillOfMaterialsViewModel());
        }
        public void LoadTransaction()
        {
            ActivateItem(new TransactionViewModel());
        }
        public void LoadReport()
        {
            ActivateItem(new ReportViewModel());
        }
        public void LoadDatabase()
        {
            ActivateItem(new DatabaseViewModel());
        }
        public void LoadHome()
        {
            ActivateItem(new HomeViewModel());
        }
        public void LoadUser()
        {
            ActivateItem(new UserViewModel());
        }
    }
}
