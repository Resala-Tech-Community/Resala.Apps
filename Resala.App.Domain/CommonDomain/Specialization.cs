using System;
using System.Collections.Generic;
using System.Text;

namespace Resala.Apps.Domain.CommonModels
{
    class Specialization : ObservableObject
    {
        public string Name { get; set; }
        public College College { get; set; }
    }
}
