﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Samples.Automapper.Shared
{
    public class TelephoneNumberModel
    {
        //1 - Home, 2 - Office, 3 - Mobile
        public int PhoneType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
