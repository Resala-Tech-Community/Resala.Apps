using System;
using System.Collections.Generic;
using System.Text;

namespace Resala.Apps.Domain.CommonModels
{
    class Branch : BaseObject
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string WhatsappNumber { get; set; }
    }
}
