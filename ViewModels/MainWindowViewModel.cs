using Caliburn.Micro;
using CIMS.Models;

namespace CIMS.ViewModels
{
    public class MainWindowViewModel : Conductor<object>
    {
        private LogInViewModel _logInVM;
        private HomeViewModel _homeVM;
        public MainWindowViewModel(LogInViewModel logInVM, HomeViewModel homeVM)
        {
            _logInVM = logInVM;
            _homeVM = homeVM;
            ActivateItem(_logInVM);
        }

        public void LoadHome()
        {
            ActivateItem(_homeVM);
        }
    }
}
