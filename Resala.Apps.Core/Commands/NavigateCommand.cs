using Resala.Apps.Core.State.Navigators;
using Resala.Apps.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Resala.Apps.Core.Commands
{
    class NavigateCommand : ICommand
    {
        private Navigator navigator = Navigator.Instance;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (parameter as ViewScreen?)
            {
                case ViewScreen.PROFILE:
                    navigator.CurrentViewModel = new ProfileViewModel();
                    break;
                case ViewScreen.SETTING:
                    navigator.CurrentViewModel = new SettingViewModel();
                    break;
                case ViewScreen.EVENTS:
                    navigator.CurrentViewModel = new EventsViewModel();
                    break;
                case ViewScreen.CALLS:
                    navigator.CurrentViewModel = new CallsViewModel();
                    break;
            }
        }
    }
}