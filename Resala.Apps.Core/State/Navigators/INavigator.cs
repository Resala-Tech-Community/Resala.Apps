using Resala.Apps.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Resala.Apps.Core.State.Navigators
{
    public enum ViewScreen { PROFILE, SETTING, EVENTS, CALLS }
    interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand NavigateCommand { get;set; }


    }
}
