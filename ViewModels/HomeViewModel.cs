using Caliburn.Micro;
using CIMS.Models;

namespace CIMS.ViewModels
{
    public class HomeViewModel:Screen 
    {
        public HomeViewModel()
        {

        }
        public void LoadEmployee()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new EmployeeViewModel());
        }
        public void LoadSupplier()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new SupplierViewModel());
        }
        public void LoadUnit()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new UnitViewModel());
        }
        public void LoadInventory()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new InventoryViewModel());
        }
        public void LoadBillOfMaterials()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new BillOfMaterialsViewModel());
        }
        public void LoadTransaction()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new TransactionViewModel());
        }
        public void LoadReport()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new ReportViewModel());
        }
        public void LoadDatabase()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new DatabaseViewModel());
        }
        public void LoadUser()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new UserViewModel());
        }

    }
}
