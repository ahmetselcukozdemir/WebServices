﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace WebService
{
    public class Identification:SoapHeader
    {
        public string userName{ get; set; }
        public string Password{ get; set; }
    }
}