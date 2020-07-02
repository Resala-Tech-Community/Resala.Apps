using System;
using System.Collections.Generic;
using System.Text;

namespace Resala.Apps.Domain.CommonModels
{
    class College : ObservableObject
    {
        public string Name { get; set; }
        public University University { get; set; }
    }
}
