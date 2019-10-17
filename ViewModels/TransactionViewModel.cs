using Caliburn.Micro;

namespace CIMS.ViewModels
{
    public class TransactionViewModel:Screen
    {
        public TransactionViewModel()
        {

        }


        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
    }
}
