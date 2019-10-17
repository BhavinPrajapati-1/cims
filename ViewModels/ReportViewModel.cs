using Caliburn.Micro;

namespace CIMS.ViewModels
{
    public class ReportViewModel:Screen
    {
        public ReportViewModel()
        {

        }


        public void LoadHome()
        {
            var conductor = this.Parent as IConductor;
            conductor.ActivateItem(new HomeViewModel());
        }
    }
}
