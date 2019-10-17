using CIMS.Models;
using CIMS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CIMS.ViewModels.HelperClasses
{
    public class UnitProgressHelperClass
    {
        private MainWindowView main = (MainWindowView)Application.Current.MainWindow;
        private UniversalHelper helper = new UniversalHelper();
        private readonly UnitViewModel thisVM = new UnitViewModel();
        private readonly UnitProgressModel thisModel = new UnitProgressModel();
        private UnitProgressModel newModel = new UnitProgressModel();

        public UnitProgressHelperClass(UnitProgressModel thisModel, UnitViewModel thisVM)
        {
            this.thisModel = thisModel;
            this.thisVM = thisVM;
            PassValuesToControls();
        }

        private void PassValuesToControls()
        {
            //if (thisModel == null) return;
            //thisVM.Name = thisModel.Name;
            //thisVM.Address = thisModel.Address;
            //thisVM.ContactNumber = thisModel.ContactNumber;
        }
    }
}
