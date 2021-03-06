﻿using Profunia.Inventory.Web.WebInfrasture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profunia.Inventory.Web.WebInfrasture
{
    public class TokenContainer : ITokenContainer
    {
        private const string ApiTokenKey = "ApiToken";

        public object ApiToken
        {
            get { return Current.Session != null ? Current.Session[ApiTokenKey] : null; }
            set { if (Current.Session != null) Current.Session[ApiTokenKey] = value; }
        }

        private static HttpContextBase Current
        {
            get { return new HttpContextWrapper(HttpContext.Current); }
        }
    }
}