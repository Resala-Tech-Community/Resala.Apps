using Resala.Apps.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resala.App.Domain.CommonDomain
{
    public enum ViewScreen { PROFILE, EVENTS, CALLS }

    public class Screen : ObservableObject
    {
        public string Name { get; set; }
        public ViewScreen Type { get; set; }

    }
}
