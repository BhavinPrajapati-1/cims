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
        private UserModel thisModel;
        private UserViewModel thisVM;

        public UserHelperClass(UserModel thisModel, UserViewModel thisVM)
        {
            this.thisModel = thisModel;
            this.thisVM = thisVM;
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
