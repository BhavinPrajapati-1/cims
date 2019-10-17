using Caliburn.Micro;

namespace CIMS.ViewModels
{
    public class UnitViewModel:Screen
    {
        public UnitViewModel()
        {

        }


        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }

    }
}
