using Caliburn.Micro;
using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.ViewModels.HelperClasses;
using CIMS.Views;
using MahApps.Metro.Controls.Dialogs;
using System.Linq;
using System.Windows;

namespace CIMS.ViewModels
{
    public class SupplierViewModel : Screen
    {
        private UniversalHelper universalHelper = new UniversalHelper();
        private SupplierHelperClass helper;

        public SupplierViewModel()
        {
            Suppliers = new BindableCollection<SupplierModel>(Read.Suppliers());
            universalHelper = new UniversalHelper();
        }

        //-----VM Methods

        public void ClearFields()
        {
            Name = "";
            Address = "";
            ContactNumber = "";
            Suppliers = new BindableCollection<SupplierModel>(Read.Suppliers());
        }

        public void RefreshTable()
        {
            ClearFields();
        }

        public void SaveData()
        {
            SupplierModel currentData = new SupplierModel();
            currentData.Name = Name;
            currentData.Address = Address;
            currentData.ContactNumber = ContactNumber;
            helper.SaveItem(currentData);
            ClearFields();
        }

        public void DeleteData()
        {
            string message = "Are you sure you want to delete " + Name + "?";
            universalHelper.YesNoDialog(message, "");
            Delete.Supplier(SelectedSupplier);
            ClearFields();
        }

        //-----VM Properties

        private BindableCollection<SupplierModel> _suppliers = new BindableCollection<SupplierModel>();
        public BindableCollection<SupplierModel> Suppliers
        {
            get
            {
                if (_selectedSupplier != null)
                    helper = new SupplierHelperClass(_selectedSupplier, this);
                return _suppliers;
            }
            set
            {
                _suppliers = value;
                NotifyOfPropertyChange(() => Suppliers);
            }
        }

        private SupplierModel _selectedSupplier = new SupplierModel();
        public SupplierModel SelectedSupplier
        {
            get
            {
                if (_selectedSupplier != null)
                    helper = new SupplierHelperClass(_selectedSupplier, this);
                return _selectedSupplier;
            }
            set
            {
                _selectedSupplier = value;
                NotifyOfPropertyChange(() => SelectedSupplier);
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                NotifyOfPropertyChange(() => Address);
            }
        }

        private string _contactNumber;
        public string ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
                NotifyOfPropertyChange(() => ContactNumber);
            }
        }
    }
}
