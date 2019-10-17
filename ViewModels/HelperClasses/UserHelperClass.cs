using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMS.Models;

namespace CIMS.ViewModels.HelperClasses
{
    public class UserHelperClass
    {
        private UserModel selectedUser;
        private UserViewModel userViewModel;

        public UserHelperClass(UserModel selectedUser, UserViewModel userViewModel)
        {
            this.selectedUser = selectedUser;
            this.userViewModel = userViewModel;
        }

        internal void SaveItem(UserModel currentData)
        {
            //throw new NotImplementedException();
        }

        internal bool CanSave()
        {
            return true;//t//hrow new NotImplementedException();
        }

        internal bool CanDelete()
        {
            return true;///throw new NotImplementedException();
        }
    }
}
