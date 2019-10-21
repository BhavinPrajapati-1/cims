using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.Views;
using System.Windows;

namespace CIMS.ViewModels.HelperClasses
{
    public class UnitHelperClass
    {
        private readonly UniversalHelper helper = new UniversalHelper();
        private readonly UnitViewModel thisVM = new UnitViewModel();
        private readonly UnitModel thisModel = new UnitModel();
        private UnitModel newModel = new UnitModel();

        public UnitHelperClass(UnitModel thisModel, UnitViewModel thisVM)
        {
            this.thisModel = thisModel;
            this.thisVM = thisVM;
            PassValuesToControls();
        }

        private void PassValuesToControls()
        {
            if(thisModel == null) return;
            thisVM.UnitName = thisModel.Name;
            thisVM.SelectedUnitType = thisModel.TypeName;
            thisVM.SelectedUnitStatuse = thisModel.StatusName;
            thisVM.UnitAddress = thisModel.Address;
            thisVM.UnitStartDate = thisModel.StartDate;
            thisVM.UnitCompletionDate = thisModel.CompletionDate;
        }

        public void SaveItem(UnitModel updatedModel)
        {
            this.newModel = updatedModel;
            if (RecordExists() && IsItemUpdated())
            {
                updatedModel.ID = thisModel.ID;
                Update.Unit(updatedModel);
                helper.MessageDialog("House Unit data has been updated successfully!",
                    updatedModel.Name);
            }
            else if (RecordExists() == true && IsItemUpdated() == false)
            {
                helper.MessageDialog("Save failed! There are no changes identified.",
                    updatedModel.Name);
            }
            else
            {
                Create.Unit(updatedModel);
                helper.MessageDialog("House Unit data has been added successfully!",
                    updatedModel.Name);
            }
        }


        public bool IsItemUpdated()
        {
            if (thisModel == null) return false;
            bool result =
                !(newModel.Name == thisModel.Name &&
                newModel.TypeName == thisModel.TypeName &&
                newModel.StatusName == thisModel.StatusName &&
                newModel.Address == thisModel.Address &&
                newModel.StartDate == thisModel.StartDate &&
                newModel.CompletionDate == thisModel.CompletionDate);
            return result;
        }

        public bool RecordExists()
        {
            if (thisModel == null) return false;
            bool result = thisModel.ID != 0;
            return result;
        }

    }
}
