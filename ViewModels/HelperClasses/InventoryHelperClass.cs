using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.Views;
using System.Windows;

namespace CIMS.ViewModels.HelperClasses
{
    public class InventoryHelperClass
    {
        private MainWindowView main = (MainWindowView)Application.Current.MainWindow;
        private UniversalHelper helper = new UniversalHelper();
        private readonly InventoryViewModel thisVM = new InventoryViewModel();
        private readonly InventoryModel thisModel = new InventoryModel();
        private InventoryModel newModel = new InventoryModel();
        public InventoryHelperClass(InventoryModel thisModel, InventoryViewModel thisVM)
        {
            this.thisModel = thisModel;
            this.thisVM = thisVM;
            PassValuesToControls();
        }

        private void PassValuesToControls()
        {
            if (thisModel == null) return;
            thisVM.ItemCode = thisModel.ItemCode;
            thisVM.Barcode = thisModel.Barcode;
            thisVM.Description = thisModel.Description;
            thisVM.SelectedClassOne = thisModel.Class1Name;
            thisVM.SelectedClassTwo = thisModel.Class2Name;
            thisVM.SelectedQuantityType = thisModel.QuantityTypeName;
            thisVM.Quantity = thisModel.Quantity;
        }
        public void SaveItem(InventoryModel updatedModel)
        {
            this.newModel = updatedModel;
            if (RecordExists() && IsItemUpdated())
            {
                updatedModel.ItemCode = thisModel.ItemCode;
                Update.Inventory(updatedModel);
                helper.MessageDialog("Employee data has been updated successfully!",
                    updatedModel.Description);
            }
            else if (RecordExists() == true && IsItemUpdated() == false)
            {
                helper.MessageDialog("Save failed! There are no changes identified.",
                    updatedModel.Description);
            }
            else
            {
                Create.Inventory(updatedModel);
                helper.MessageDialog("Employee data has been added successfully!",
                    updatedModel.Description);
            }
        }

        public bool IsItemUpdated()
        {
            if (thisModel == null) return false;
            bool result =
                !(newModel.Barcode == thisModel.Barcode &&
                newModel.Description == thisModel.Description &&
                newModel.Class1_ID == thisModel.Class1_ID &&
                newModel.Class2_ID == thisModel.Class2_ID &&
                newModel.QuantityType_ID == thisModel.QuantityType_ID &&
                newModel.Quantity == thisModel.Quantity);
            return result;
        }

        public bool RecordExists()
        {
            if (thisModel == null) return false;
            bool result = thisModel.ItemCode != "";
            return result;
        }

    }
}
