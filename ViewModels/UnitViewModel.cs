using System;
using System.Linq;
using Caliburn.Micro;
using CIMS.Models;
using CIMS.Models.Validators;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.ViewModels.HelperClasses;
using FluentValidation.Results;

namespace CIMS.ViewModels
{
    public class UnitViewModel:Screen
    {
        private readonly UniversalHelper universalHelper;
        private UnitProgressHelperClass upHelper;
        private UnitHelperClass uHelper;

        public UnitViewModel()
        {
            Units = new BindableCollection<UnitModel>(Read.Units());
            ProgressOfUnits = new BindableCollection<UnitProgressModel>(Read.UnitProgress());
            UnitTypes = new BindableCollection<string>(Read.Dropdown("UnitType"));
            UnitStatuses = new BindableCollection<string>(Read.Dropdown("UnitStatus"));
            universalHelper = new UniversalHelper();
        }


        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
        #region Unit
        public void RefreshUnitTable()
        {
            ClearUnitFields();
        }

        private void ClearUnitFields()
        {
            UnitName = "";
            SelectedUnitType = null;
            SelectedUnitStatuse = null;
            UnitAddress = "";
            UnitStartDate = null;
            UnitCompletionDate = null;
            Units = new BindableCollection<UnitModel>(Read.Units());
            SelectedUnit = new UnitModel();
        }

        public void SaveUnit()
        {
            UnitModel currentUnit = new UnitModel();
            CollectUnitDetails(currentUnit);
            UnitValidator validator = new UnitValidator();
            ValidationResult result = validator.Validate(currentUnit);
            if (result.IsValid == false)
            {
                string errorMessage = (String.Join(Environment.NewLine + "   • ",
                 result.Errors.Select(error => error.ErrorMessage)));
                universalHelper.MessageDialog("Saving of data failed!", "   • " + errorMessage);
                return;
            }
            else
            {
                uHelper.SaveItem(currentUnit);
                ClearUnitFields();
            }
        }

        private void CollectUnitDetails(UnitModel currentUnit)
        {
            int statusID = Read.DropdownID("UnitStatus", SelectedUnitStatuse).FirstOrDefault();
            int typeID = Read.DropdownID("UnitType", SelectedUnitType).FirstOrDefault();
            currentUnit.Name = UnitName;
            currentUnit.TypeName = SelectedUnitType;
            currentUnit.Type_ID = typeID;
            currentUnit.StatusName = SelectedUnitStatuse;
            currentUnit.Status_ID = statusID;
            currentUnit.Address = UnitAddress;
            currentUnit.StartDate = UnitStartDate;
            currentUnit.CompletionDate = UnitCompletionDate;
        }
        public void DeleteUnit()
        {
            if (!uHelper.RecordExists()) return;
            string message = "You are about to delete " + SelectedUnit.Name + ". Are you sure?";
            if (universalHelper.HasAgreed(message, "Delete Unit"))
            {
                Delete.Unit(SelectedUnit);
                ClearUnitFields();
            }
        }


        //-----VM Properties

        private BindableCollection<UnitModel> _units = new BindableCollection<UnitModel>();
        public BindableCollection<UnitModel> Units
        {
            get
            {
                return _units;
            }
            set
            {
                _units = value;
                NotifyOfPropertyChange(() => Units);
            }
        }

        private UnitModel _selectedUnit = new UnitModel();
        public UnitModel SelectedUnit
        {
            get
            {
                if (_selectedUnit != null)
                    uHelper = new UnitHelperClass(_selectedUnit, this);
                return _selectedUnit;
            }
            set
            {
                _selectedUnit = value;
                NotifyOfPropertyChange(() => SelectedUnit);
            }
        }

        private BindableCollection<string> _unitTypes = new BindableCollection<string>();
        public BindableCollection<string> UnitTypes
        {
            get
            { 
                return _unitTypes;
            }
            set
            {
                _unitTypes = value;
                NotifyOfPropertyChange(() => UnitTypes);
            }
        }

        private string _selectedUnitType;
        public string SelectedUnitType
        {
            get
            {
                return _selectedUnitType;
            }
            set
            {
                _selectedUnitType = value;
                NotifyOfPropertyChange(() => SelectedUnitType);
            }
        }

        private BindableCollection<string> _unitStatus = new BindableCollection<string>();
        public BindableCollection<string> UnitStatuses
        {
            get
            {
                return _unitStatus;
            }
            set
            {
                _unitStatus = value;
                NotifyOfPropertyChange(() => UnitStatuses);
            }
        }

        private string _selectedUnitStatus;
        public string SelectedUnitStatuse
        {
            get
            {
                return _selectedUnitStatus;
            }
            set
            {
                _selectedUnitStatus = value;
                NotifyOfPropertyChange(() => SelectedUnitStatuse);
            }
        }
        private string _unitName;
        public string UnitName
        {
            get
            {
                return _unitName;
            }
            set
            {
                _unitName = value;
                NotifyOfPropertyChange(() => UnitName);
            }
        }

        private string _unitAddress;
        public string UnitAddress
        {
            get
            {
                return _unitAddress;
            }
            set
            {
                _unitAddress = value;
                NotifyOfPropertyChange(() => UnitAddress);
            }
        }

        private string _unitStartDate;
        public string UnitStartDate
        {
            get
            {
                return _unitStartDate;
            }
            set
            {
                _unitStartDate = value;
                NotifyOfPropertyChange(() => UnitStartDate);
            }
        }

        private string _unitCompletionDate;
        public string UnitCompletionDate
        {
            get
            {
                return _unitCompletionDate;
            }
            set
            {
                _unitCompletionDate = value;
                NotifyOfPropertyChange(() => UnitCompletionDate);
            }
        }

        #endregion

        #region UnitProgress
        //-----VM Properties


        private BindableCollection<UnitProgressModel> _unitProgress = new BindableCollection<UnitProgressModel>();
        public BindableCollection<UnitProgressModel> ProgressOfUnits
        {
            get
            {
                return _unitProgress;
            }
            set
            {
                _unitProgress = value;
                NotifyOfPropertyChange(() => Units);
            }
        }

        private UnitProgressModel _selectedProgressUnits = new UnitProgressModel();
        public UnitProgressModel SelectedProgressOfUnit
        {
            get
            {
                if (_selectedProgressUnits != null)
                    upHelper = new UnitProgressHelperClass(_selectedProgressUnits, this);
                return _selectedProgressUnits;
            }
            set
            {
                _selectedProgressUnits = value;
                NotifyOfPropertyChange(() => SelectedProgressOfUnit);
            }
        }


        #endregion

    }
}
