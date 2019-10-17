﻿using Caliburn.Micro;
using CIMS.Models;

namespace CIMS.ViewModels
{
    public class MainWindowViewModel : Conductor<object>
    {
        private LogInViewModel _logInVM;
        public MainWindowViewModel(LogInViewModel logInVM)
        {
            _logInVM = logInVM;
            ActivateItem(_logInVM);
        }

    }
}
