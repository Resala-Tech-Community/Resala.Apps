using System;
using System.Collections.Generic;
using System.Text;

namespace Resala.Apps.Models.CommonModels
{
    class Specialization : BaseObject
    {
        public string Name { get; set; }
        public College College { get; set; }
    }
}
