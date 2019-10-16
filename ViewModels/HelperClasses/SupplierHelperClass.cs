using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CIMS.ViewModels.HelperClasses
{
    public class SupplierHelperClass
    {
        private MainWindowView main = (MainWindowView)Application.Current.MainWindow;
        private UniversalHelper helper = new UniversalHelper();
        private readonly SupplierViewModel thisVM = new SupplierViewModel();
        private readonly SupplierModel thisModel = new SupplierModel();
        private SupplierModel newModel = new SupplierModel();

        public SupplierHelperClass(SupplierModel thisModel, SupplierViewModel thisVM)
        {
            this.thisModel = thisModel;
            this.thisVM = thisVM;
            PassValuesToControls();
        }

        private void PassValuesToControls()
        {
            if (thisModel == null) return;
            thisVM.Name = thisModel.Name;
            thisVM.Address = thisModel.Address;
            thisVM.ContactNumber = thisModel.ContactNumber;
        }

        public bool CanDelete()
        {
            return (RecordExists() && IsItemUpdated());
        }

        public bool CanSave()
        {
            if (thisModel == null) return false;
            bool result =
                thisVM.Name != "" ||
                thisVM.Address != "" ||
                thisVM.ContactNumber != "";
            return result;
        }

        public void SaveItem(SupplierModel updatedModel)
        {
            this.newModel = updatedModel;
            if (RecordExists() && IsItemUpdated())
            {
                updatedModel.ID = thisModel.ID;
                Update.Supplier(updatedModel);
                helper.MessageDialog("Supplier data has been updated successfully!",
                    updatedModel.Name);
            }
            else
            {
                Create.Supplier(updatedModel);
                helper.MessageDialog("Supplier data has been added successfully!",
                    updatedModel.Name);
            }
        }

        public bool IsItemUpdated()
        {
            if (thisModel == null) return false;
            bool result =
                !(newModel.Name == thisModel.Name &&
                newModel.Address == thisModel.Address &&
                newModel.ContactNumber == thisModel.ContactNumber);
            return result;
        }

        private bool RecordExists()
        {
            if (thisModel == null) return false;
            bool result =
                thisModel.Name != null &&
                thisModel.Address != null &&
                thisModel.ContactNumber != null;
            return result;
        }

    }
}
