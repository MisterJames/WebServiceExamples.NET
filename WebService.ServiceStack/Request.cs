﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceHost;

namespace WebService.ServiceStack
{
    [RestService("/ToUpper/{input}")]
    public class Request
    {
        public string Input { get; set; }
    }
}