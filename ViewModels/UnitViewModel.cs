using Caliburn.Micro;
using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.ViewModels.HelperClasses;

namespace CIMS.ViewModels
{
    public class UnitViewModel:Screen
    {
        private UnitProgressHelperClass upHelper;
        private UnitHelperClass uHelper;
        private UniversalHelper universalHelper;

        public UnitViewModel()
        {
            Units = new BindableCollection<UnitModel>(Read.Units());
            ProgressOfUnits = new BindableCollection<UnitProgressModel>(Read.UnitProgress());
            universalHelper = new UniversalHelper();
        }


        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
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
                    upHelper=new UnitProgressHelperClass(_selectedProgressUnits, this);
                return _selectedProgressUnits;
            }
            set
            {
                _selectedProgressUnits = value;
                NotifyOfPropertyChange(() => SelectedProgressOfUnit);
            }
        }
    }
}
