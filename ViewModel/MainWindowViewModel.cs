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
        private DataTable _supplierTable;

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


        public DataTable SupplierTable
        {
            get
            {
                return _supplierTable;
            }
            set
            {
                if (value == _supplierTable) return;
                _supplierTable = value;
                OnPropertyChanged("SupplierTable");
            }
        }
    }
}
