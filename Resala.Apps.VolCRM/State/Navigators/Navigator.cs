using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Resala.Apps.VolCRM.Commands;
using Resala.Apps.VolCRM.ViewModels;
using Resala.Apps.Domain;
using System.Threading;
using System.Collections.ObjectModel;
using Resala.App.Domain.CommonDomain;

namespace Resala.Apps.VolCRM.State.Navigators
{
    /// <summary>
    /// Singletone Navigator
    /// </summary>
    public class Navigator : ObservableObject ,INavigator
    {

        public ObservableCollection<Screen> Screens { get; set; }
        public ICommand NavigateCommand { get; }



        private static Navigator instance = null;
        private static object padLock = new object();
        public static Navigator Instance
        {
            get
            {
                // thread-safe object creatation with double check to avoid locking with every getting process.
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                            instance = new Navigator();
                    }
                }
                return instance;
            }
        }


        private ViewModelBase currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }


        private Navigator()
        {
            NavigateCommand = new RelayCommand(NavigationCommandExecute);
        }

        


        public void NavigationCommandExecute(object parameter)
        {
            switch (parameter as ViewScreen?)
            {
                case ViewScreen.PROFILE:
                    CurrentViewModel = new ProfileViewModel();
                    break;
                case ViewScreen.EVENTS:
                    CurrentViewModel = new EventsViewModel();
                    break;
                case ViewScreen.CALLS:
                    CurrentViewModel = new CallsViewModel();
                    break;
            }
        }

    }
}
