using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Resala.Apps.Domain
{
    public class BaseObject : INotifyPropertyChanged
    {
        public int ID { get; set; }


        // Propoerty Change notify //
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propName));
        }
    }
}
