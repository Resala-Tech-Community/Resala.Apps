using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Resala.Apps.Core.Commands;
using Resala.Apps.Core.ViewModels;
using Resala.Apps.Domain;

namespace Resala.Apps.Core.State.Navigators
{
    /// <summary>
    /// Singletone Navigator
    /// </summary>
    class Navigator : ObservableObject ,INavigator
    {
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

        private Navigator()
        {
            NavigateCommand = new NavigateCommand();
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

        
        public ICommand NavigateCommand  { get ; set; }
    }
}
