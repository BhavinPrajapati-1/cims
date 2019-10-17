using Caliburn.Micro;

namespace CIMS.ViewModels
{
    public class DatabaseViewModel:Screen
    {
        public DatabaseViewModel()
        {

        }




        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
    }
}
