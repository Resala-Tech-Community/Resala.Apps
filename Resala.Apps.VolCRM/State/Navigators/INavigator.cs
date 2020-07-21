using Resala.App.Domain.CommonDomain;
using Resala.Apps.VolCRM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Resala.Apps.VolCRM.State.Navigators
{
    interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand NavigateCommand { get;}
        ObservableCollection<Screen> Screens { get; set; }



    }
}
