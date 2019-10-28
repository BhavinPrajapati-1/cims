using System;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using Caliburn.Micro;
using CIMS.Models;
using CIMS.Models.Validators;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.ViewModels.HelperClasses;
using CIMS.Views;
using FluentValidation.Results;

namespace CIMS.ViewModels
{
    public class UnitViewModel:Screen
    {
        private MainWindowView main = (MainWindowView)Application.Current.MainWindow;
        private readonly UniversalHelper universalHelper;
        private UnitProgressHelperClass upHelper;
        private UnitHelperClass uHelper;
        public UnitViewModel()
        {
            ProgressOfUnits = new BindableCollection<UnitProgressModel>(Read.UnitProgress());
            Units = new BindableCollection<UnitModel>(Read.Units());
            UnitNames = new BindableCollection<string>(Read.Dropdown("Unit"));
            UnitTypes = new BindableCollection<string>(Read.Dropdown("UnitType"));
            UnitStatuses = new BindableCollection<string>(Read.Dropdown("UnitStatus"));
            RightSideUP = false;
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
            int selectedTab = SelectedTabIndex;
            UnitName = "";
            SelectedUnitType = null;
            SelectedUnitStatuse = null;
            UnitAddress = "";
            UnitStartDate = null;
            UnitCompletionDate = null;
            Units = new BindableCollection<UnitModel>(Read.Units());
            SelectedUnit = new UnitModel();
            SelectedTabIndex = selectedTab;
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
        public void RefreshProgressTable()
        {
            RightSideUP = false;
            ClearProgressFields();
        }
        public void AddNewProgress()
        {
            RefreshProgressTable();
            RightSideUP = true;
        }

        private void ClearProgressFields()
        {
            int selectedTab = SelectedTabIndex;
            UnitName = "";
            SelectedUnitType = null;
            SelectedUnitStatuse = null;
            UnitAddress = "";
            UnitStartDate = null;
            UnitCompletionDate = null;
            ProgressOfUnits = new BindableCollection<UnitProgressModel>(Read.UnitProgress());
            SelectedProgressOfUnit = new UnitProgressModel();
            LoadUnit();
            SelectedTabIndex = selectedTab;
        }

        public void LoadUnit()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new UnitViewModel());
            conductor.ActivateItem(new UnitViewModel());
        }
        public void SaveProgress()
        {
            UnitProgressModel currentProgress = new UnitProgressModel();
            CollectProgressDetails(currentProgress);
            UnitProgressValidator validator = new UnitProgressValidator();
            ValidationResult result = validator.Validate(currentProgress);
            if (result.IsValid == false)
            {
                string errorMessage = (String.Join(Environment.NewLine + "   • ",
                 result.Errors.Select(error => error.ErrorMessage)));
                universalHelper.MessageDialog("Saving of data failed!", "   • " + errorMessage);
                return;
            }
            else
            {
                upHelper.SaveItem(currentProgress);
                RefreshProgressTable();
                RightSideUP = false;
            }
        }

        public void SetUnitValues()
        {
            if (SelectedUnitName != "" && SelectedUnitName != null)
            {
                UnitProgressModel unit = new UnitProgressModel();
                unit = Read.UnitProgress().Where(x => x.UnitName== SelectedUnitName).FirstOrDefault();
                CurrentUnitType = unit.UnitTypeName; 
                CurrentAddress = unit.UnitAddress;
            }
        }
        private void CollectProgressDetails(UnitProgressModel currentProgress)
        {
            int statusID = Read.DropdownID("UnitStatus", SelectedUnitStatuse).FirstOrDefault();
            int typeID = Read.DropdownID("UnitType", CurrentUnitType).FirstOrDefault();
            UnitProgressModel unit = new UnitProgressModel();
            unit = Read.UnitProgress().Where(x => x.UnitName == SelectedUnitName).FirstOrDefault();
            currentProgress.Unit_ID = unit.ID;
            currentProgress.UnitName = SelectedUnitName;
            currentProgress.UnitTypeName = CurrentUnitType;
            currentProgress.UnitType_ID = typeID;
            currentProgress.UnitStatusName = SelectedUnitStatuse;
            currentProgress.Status_ID = statusID;
            currentProgress.Notes = Notes;
            currentProgress.UnitAddress = CurrentAddress;
            currentProgress.Image = upHelper.ReadImageFile(FileLocation);
            currentProgress.Employee_ID = (int)main.lblEmployeeID.Content;
        }
        public void DeleteProgress()
        {
            if (!upHelper.RecordExists()) return;
            string message = " Are you sure you want to delete the selected item?";
            if (universalHelper.HasAgreed(message, "Delete Unit Progress"))
            {
                Delete.UnitProgress(SelectedProgressOfUnit);
                message = "Item deleted successfully.";
                universalHelper.MessageDialog(message, "");
                ClearProgressFields();
            }
        }


        public void SelectImage()
        {
            FileLocation = upHelper.ImageFilePath();
            UnitImage = upHelper.ReadImageFile(FileLocation);
            ConvertedImage = upHelper.ByteArrayToImage(UnitImage);
        }

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
                {
                    upHelper = new UnitProgressHelperClass(_selectedProgressUnits, this);
                    RightSideUP = false;
                }
                return _selectedProgressUnits;
            }
            set
            {
                _selectedProgressUnits = value;
                NotifyOfPropertyChange(() => SelectedProgressOfUnit);
            }
        }
        private BindableCollection<string> _unitNames = new BindableCollection<string>();
        public BindableCollection<string> UnitNames
        {
            get
            {
                return _unitNames;
            }
            set
            {
                _unitNames = value;
                NotifyOfPropertyChange(() => UnitNames);
            }
        }

        private string _selectedUnitName;
        public string SelectedUnitName
        {
            get
            {
                return _selectedUnitName;
            }
            set
            {
                _selectedUnitName = value;
                NotifyOfPropertyChange(() => SelectedUnitName);
            }
        }
        private byte[] _unitImage;
        public byte[] UnitImage
        {
            get
            {
                return _unitImage;
            }
            set
            {
                _unitImage = value;
                NotifyOfPropertyChange(() => UnitImage);
            }
        }
        private BitmapImage _convertedImage;
        public BitmapImage ConvertedImage
        {
            get
            {
                return _convertedImage;
            }
            set
            {
                _convertedImage=value;
                NotifyOfPropertyChange(() => ConvertedImage);
            }
        }
        private string _notes;
        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
                NotifyOfPropertyChange(() => Notes);
            }
        }
        private string _fileLocation;
        public string FileLocation
        {
            get { return _fileLocation; }
            set
            {
                _fileLocation = value;
                NotifyOfPropertyChange(() => FileLocation);
            }
        }
        private string _currentUnit;
        public string CurrentUnit
        {
            get { return _currentUnit; }
            set
            {
                _currentUnit = value;
                NotifyOfPropertyChange(() => CurrentUnit);
            }
        }
        private string _currentAddress;
        public string CurrentAddress
        {
            get { return _currentAddress; }
            set
            {
                _currentAddress = value;
                NotifyOfPropertyChange(() => CurrentAddress);
            }
        }
        private string _currentUnitType;
        public string CurrentUnitType
        {
            get { return _currentUnitType; }
            set
            {
                _currentUnitType = value;
                NotifyOfPropertyChange(() => CurrentUnitType);
            }
        }
        private bool _isRightSideUPVisible;
        public bool RightSideUP
        {
            get { return _isRightSideUPVisible; }
            set
            {
                _isRightSideUPVisible = value;
                NotifyOfPropertyChange(() => RightSideUP);
            }
        }
        private int _selectedTabIndex;
        public int SelectedTabIndex
        {
            get { return _selectedTabIndex; }
            set
            {
                _selectedTabIndex = value;
                NotifyOfPropertyChange(() => SelectedTabIndex);
            }
        }
        #endregion

    }
}
