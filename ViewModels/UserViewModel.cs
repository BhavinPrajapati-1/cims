using Caliburn.Micro;
using CIMS.Models;
using CIMS.ViewModels.DatabaseConnection.CRUD;
using CIMS.ViewModels.HelperClasses;
using System.Linq;

namespace CIMS.ViewModels
{
    public class UserViewModel : Screen 
    {
        private UserHelperClass helper;
        private UniversalHelper universalHelper;
        public UserViewModel()
        {
            Users = new BindableCollection<UserModel>(Read.Users());
            universalHelper = new UniversalHelper();
        }

        //-----VM Methods

        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
        public void ClearFields()
        {
            //StringVM = "";
            //IntVM = 0;
            //ObjectVM = null;
            Users = new BindableCollection<UserModel>(Read.Users());
        }

        public void RefreshTable()
        {
            ClearFields();
        }

        public void SaveData()
        {
            UserModel currentData = new UserModel();
            //currentData.StringVM = StringVM;
            //currentData.IntVM = IntVM;
            //currentData.ObjectVM = ObjectVM;
            helper.SaveItem(currentData);
            ClearFields();
        }

        public bool CanSaveData
        {
            get
            {
                bool result = helper.CanSave();
                return result;
            }
        }
        public void DeleteData()
        {
            string largeText = "Are you sure you want to delete " + "Property" + "?"; //***UPDATE HERE***
            string smallText = "";  
            universalHelper.YesNoDialog(largeText, smallText);
            Delete.User(SelectedUser);
            ClearFields();
        }

        public bool CanDeleteData
        {
            get
            {
                bool result = helper.CanDelete();
                return result;
            }
        }

        //-----VM Properties

        private BindableCollection<UserModel> _users = new BindableCollection<UserModel>();
        public BindableCollection<UserModel> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                NotifyOfPropertyChange(() => Users);
            }
        }

        private UserModel _selectedUser = new UserModel();
        public UserModel SelectedUser
        {
            get
            {
                if (_selectedUser != null)
                    helper = new UserHelperClass(_selectedUser, this);
                return _selectedUser;
            }
            set
            {
                _selectedUser = value;
                NotifyOfPropertyChange(() => SelectedUser);
            }
        }

        //***UPDATE HERE***
        private BindableCollection<string> _comboBox = new BindableCollection<string>();
        public BindableCollection<string> ComboBox
        {
            get
            {
                return _comboBox;
            }
            set
            {
                _comboBox = value;
                NotifyOfPropertyChange(() => ComboBox);
            }
        }

        //***UPDATE HERE***
        private string _selectedComboBox;
        public string SelectedComboBox
        {
            get
            {
                return _selectedComboBox;
            }
            set
            {
                _selectedComboBox = value;
                NotifyOfPropertyChange(() => ComboBoxId);
                NotifyOfPropertyChange(() => SelectedComboBox);
            }
        }

        //***UPDATE HERE***
        private int _comboBoxId;
        public int ComboBoxId
        {
            get
            {
                _comboBoxId = Read.DropdownID("UserPosition",
                    SelectedComboBox).FirstOrDefault();
                return _comboBoxId;
            }
            set
            {
                _comboBoxId = value;
                NotifyOfPropertyChange(() => ComboBoxId);
                NotifyOfPropertyChange(() => SelectedComboBox);
            }
        }

        //***UPDATE HERE***
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

        //***UPDATE HERE***
        private int _intSample;
        public int IntSample
        {
            get
            {
                return _intSample;
            }
            set
            {
                _intSample = value;
                NotifyOfPropertyChange(() => IntSample);
            }
        }

    }
}
