﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Resala.Apps.Models.CommonModels
{
    class College : BaseObject
    {
        public string Name { get; set; }
        public University University { get; set; }
    }
}