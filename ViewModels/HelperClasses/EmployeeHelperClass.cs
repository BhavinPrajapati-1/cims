using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.Views;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Windows;

namespace CIMS.ViewModels.HelperClasses
{
    public class EmployeeHelperClass
    {
        MainWindowView main = (MainWindowView)Application.Current.MainWindow;
        private readonly EmployeeModel employee;
        private EmployeeModel updatedModel;
        private readonly EmployeeViewModel employeeVM;

        public EmployeeHelperClass(EmployeeModel employee, EmployeeViewModel employeeVM)
        {
            this.employee = new EmployeeModel();
            this.employeeVM = new EmployeeViewModel();
            this.employee = employee;
            this.employeeVM = employeeVM;
            ShowValuesToTextBoxes();

        }
        private async void PromptMessage(string largeText, string smalltext)
        {
            await main.ShowMessageAsync(largeText, smalltext);
        }
        private void ShowValuesToTextBoxes()
        {
            if (employee == null) return;
            employeeVM.FirstName = employee.FirstName;
            employeeVM.MiddleName= employee.MiddleName;
            employeeVM.LastName = employee.LastName;
            employeeVM.SelectedPosition = employee.PositionName;
            employeeVM.ContactNumber = employee.ContactNumber;
            employeeVM.EmailAddress = employee.EmailAddress;
        }
        public void SaveEmployee(EmployeeModel updatedModel)
        {
            this.updatedModel = updatedModel;
            if (RecordExists() && IsEmployeeUpdated())
            {
                updatedModel.ID = employee.ID;
                Update.Employee(updatedModel);
                PromptMessage("Employee data has been updated successfully!", "");
            }
            else
            {
                Create.Employee(updatedModel);
                PromptMessage("Employee data has been added successfully!", "");
            }
        }

        public bool IsEmployeeUpdated()
        {
            if (employee == null) return false;
            bool result =
                updatedModel.FirstName == employee.FirstName &&
                updatedModel.MiddleName == employee.MiddleName &&
                updatedModel.LastName == employee.LastName &&
                updatedModel.Position_ID == employee.Position_ID &&
                updatedModel.ContactNumber == employee.ContactNumber &&
                updatedModel.EmailAddress == employee.EmailAddress;
            return result==false;
        }

        private bool RecordExists()
        {
            if (employee == null) return false;
            bool result =
                employee.FirstName != null &&
                employee.MiddleName != null &&
                employee.LastName != null &&
                employee.Position_ID != 0 &&
                employee.ContactNumber != null &&
                employee.EmailAddress != null;
            return result;
        }

    }
}
