using Caliburn.Micro;

namespace CIMS.ViewModels
{
    public class InventoryViewModel:Screen
    {
        public InventoryViewModel()
        {

        }



        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
    }
}
