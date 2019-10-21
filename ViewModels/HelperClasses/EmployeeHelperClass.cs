using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.Views;
using System.Windows;

namespace CIMS.ViewModels.HelperClasses
{
    public class EmployeeHelperClass
    {
        private readonly UniversalHelper helper = new UniversalHelper();
        private readonly EmployeeViewModel thisVM = new EmployeeViewModel();
        private readonly EmployeeModel thisModel = new EmployeeModel();
        private EmployeeModel newModel = new EmployeeModel();

        public EmployeeHelperClass(EmployeeModel thisModel, EmployeeViewModel thisVM)
        {
            this.thisModel = thisModel;
            this.thisVM = thisVM;
            PassValuesToControls();
        }

        private void PassValuesToControls()
        {
            if (thisModel == null) return;
            thisVM.FirstName = thisModel.FirstName;
            thisVM.MiddleName = thisModel.MiddleName;
            thisVM.LastName = thisModel.LastName;
            thisVM.SelectedPosition = thisModel.PositionName;
            thisVM.ContactNumber = thisModel.ContactNumber;
            thisVM.EmailAddress = thisModel.EmailAddress;
        }


        public void SaveItem(EmployeeModel updatedModel)
        {
            this.newModel = updatedModel;
            if (RecordExists() && IsItemUpdated())
            {
                updatedModel.ID = thisModel.ID;
                Update.Employee(updatedModel);
                helper.MessageDialog("Employee data has been updated successfully!",
                    updatedModel.FullName);
            }
            else if (RecordExists() == true && IsItemUpdated() == false)
            {
                helper.MessageDialog("Save failed! There are no changes identified.",
                    updatedModel.FullName);
            }
            else
            {
                Create.Employee(updatedModel);
                helper.MessageDialog("Employee data has been added successfully!",
                    updatedModel.FullName);
            }
        }

        public bool IsItemUpdated()
        {
            if (thisModel == null) return false;
            bool result =
                !(newModel.FirstName == thisModel.FirstName &&
                newModel.MiddleName == thisModel.MiddleName &&
                newModel.LastName == thisModel.LastName &&
                newModel.Position_ID == thisModel.Position_ID &&
                newModel.ContactNumber == thisModel.ContactNumber &&
                newModel.EmailAddress == thisModel.EmailAddress);
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
