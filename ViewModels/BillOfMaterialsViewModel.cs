using Caliburn.Micro;

namespace CIMS.ViewModels
{
    public class BillOfMaterialsViewModel:Screen
    {
        public BillOfMaterialsViewModel()
        {

        }



        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
    }
}
