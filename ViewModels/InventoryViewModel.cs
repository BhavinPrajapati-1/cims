using Caliburn.Micro;
using CIMS.Models;
using CIMS.Models.Validators;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.ViewModels.HelperClasses;
using FluentValidation.Results;
using System;
using System.Linq;

namespace CIMS.ViewModels
{
    public class InventoryViewModel:Screen
    {
        private readonly UniversalHelper universalHelper;
        private InventoryHelperClass helper;
        public InventoryViewModel()
        {
            InventoryItems = new BindableCollection<InventoryModel>(Read.Inventory());
            ClassOnes = new BindableCollection<string>(Read.Dropdown("InventoryClassOne"));
            ClassTwos = new BindableCollection<string>(Read.Dropdown("InventoryClassTwo"));
            QuantityTypes = new BindableCollection<string>(Read.Dropdown("InventoryQuantityType"));
            universalHelper = new UniversalHelper();
        }
        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
        #region InventoryMethods
        public void ClearFields()
        {
            ItemCode = "";
            Barcode = 0;
            Description = "";
            Quantity = 0;
            SelectedClassOne = null;
            SelectedClassTwo = null;
            SelectedQuantityType = null;
            InventoryItems = new BindableCollection<InventoryModel>(Read.Inventory());
            SelectedInventoryItem = new InventoryModel();

        }
        public void RefreshTable()
        {
            ClearFields();
        }
        public void SaveData()
        {
            InventoryModel currentData = new InventoryModel();
            CollectDetails(currentData);
            InventoryValidator validator = new InventoryValidator();
            ValidationResult result = validator.Validate(currentData);
            if (result.IsValid == false)
            {
                string errorMessage = (String.Join(Environment.NewLine + "   • ",
                 result.Errors.Select(error => error.ErrorMessage)));
                universalHelper.MessageDialog("Saving of data failed!", "   • " + errorMessage);
                return;
            }
            else
            {
                helper.SaveItem(currentData);
            }
        }
        private void CollectDetails(InventoryModel currentData)
        {
            int classOneID = Read.DropdownID("InventoryClassOne", SelectedClassOne).FirstOrDefault();
            int classTwoID = Read.DropdownID("InventoryClassTwo", SelectedClassTwo).FirstOrDefault();
            int quantityTypeID = Read.DropdownID("InventoryQuantityType", SelectedQuantityType).FirstOrDefault();
            currentData.ItemCode = ItemCode;

        }
        public void DeleteData()
        {
            if (!helper.RecordExists()) return;
            string message = "Are you sure you want to delete " + SelectedInventoryItem.Description + "?";
            bool canDelete = universalHelper.HasAgreed(message, "Delete Inventory Item");
            if (canDelete == false) return;
            message = "Item deleted successfully.";
            universalHelper.MessageDialog(message, "");
            Delete.Inventory(SelectedInventoryItem);
            ClearFields();
        }

        #endregion

        #region InventoryProperties
        private BindableCollection<InventoryModel> _inventoryItems = new BindableCollection<InventoryModel>();
        public BindableCollection<InventoryModel> InventoryItems
        {
            get
            {
                return _inventoryItems;
            }
            set
            {
                _inventoryItems = value;
                NotifyOfPropertyChange(() => InventoryItems);
            }
        }

        private InventoryModel _selectedInventoryItem = new InventoryModel();
        public InventoryModel SelectedInventoryItem
        {
            get
            {
                if (_selectedInventoryItem != null)
                    helper = new InventoryHelperClass(_selectedInventoryItem, this);
                return _selectedInventoryItem;
            }
            set
            {
                _selectedInventoryItem = value;
                NotifyOfPropertyChange(() => SelectedInventoryItem);
            }
        }

        private BindableCollection<string> _classOnes = new BindableCollection<string>();
        public BindableCollection<string> ClassOnes
        {
            get
            {
                return _classOnes;
            }
            set
            {
                _classOnes = value;
                NotifyOfPropertyChange(() => ClassOnes);
            }
        }

        private string _selectedClassOne;
        public string SelectedClassOne
        {
            get
            {
                return _selectedClassOne;
            }
            set
            {
                _selectedClassOne = value;
                NotifyOfPropertyChange(() => SelectedClassOne);
            }
        }

        private BindableCollection<string> _classTwos = new BindableCollection<string>();
        public BindableCollection<string> ClassTwos
        {
            get
            {
                return _classTwos;
            }
            set
            {
                _classTwos = value;
                NotifyOfPropertyChange(() => ClassTwos);
            }
        }

        private string _selectedClassTwo;
        public string SelectedClassTwo
        {
            get
            {
                return _selectedClassTwo;
            }
            set
            {
                _selectedClassTwo = value;
                NotifyOfPropertyChange(() => SelectedClassTwo);
            }
        }

        private BindableCollection<string> _quantityTypes = new BindableCollection<string>();
        public BindableCollection<string> QuantityTypes
        {
            get
            {
                return _quantityTypes;
            }
            set
            {
                _quantityTypes = value;
                NotifyOfPropertyChange(() => QuantityTypes);
            }
        }

        private string _selectedQuantityType;
        public string SelectedQuantityType
        {
            get
            {
                return _selectedQuantityType;
            }
            set
            {
                _selectedQuantityType = value;
                NotifyOfPropertyChange(() => SelectedQuantityType);
            }
        }

        private string _itemCode;
        public string ItemCode
        {
            get
            {
                return _itemCode;
            }
            set
            {
                _itemCode = value;
                NotifyOfPropertyChange(() => ItemCode);
            }
        }
        private int _barCode;
        public int Barcode
        {
            get
            {
                return _barCode;
            }
            set
            {
                _barCode = value;
                NotifyOfPropertyChange(() => Barcode);
            }
        }
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                NotifyOfPropertyChange(() => Description);
            }
        }
        private double _quantity;
        public double Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                NotifyOfPropertyChange(() => Quantity);
            }
        }

        #endregion



    }
}
