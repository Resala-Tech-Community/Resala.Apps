using Resala.App.Domain.CommonDomain;
using Resala.Apps.VolCRM.State.Navigators;
using Resala.Apps.VolCRM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Resala.Apps.VolCRM
{
    public class MainViewModel : ViewModelBase
    {
        public Navigator Navigator { get; }

        public MainViewModel()
        {
            Navigator = Navigator.Instance;

            Navigator.Screens = new ObservableCollection<Screen>()
            {
                new Screen(){Name="Profile",Type=ViewScreen.PROFILE},
                new Screen(){Name="Calls",Type=ViewScreen.CALLS},
                new Screen(){Name="Events",Type=ViewScreen.EVENTS}
            };

            Navigator.NavigateCommand.Execute(ViewScreen.PROFILE);
        }



    }
}
