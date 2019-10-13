using CIMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.ViewModel
{
    public class MainWindowViewModel : PropertyChangeHandler
    {
        private User _currentUser;
        private Dropdown _dropdown;

        public User CurrentUser {
            get
            {
                return _currentUser;
            }
            set
            {
                if (value == _currentUser) return;
                _currentUser = value;
                OnPropertyChanged("CurrentUser");
            }
        }
        public Dropdown DropdownValues
        {
            get
            {
                return _dropdown;
            }
            set
            {
                if (value == _dropdown) return;
                _dropdown = value;
                OnPropertyChanged("DropdownValues");
            }
        }

    }
}
