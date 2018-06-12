using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profunia.Inventory.Web.Models
{
    public class ErrorStateResponse
    {
        public string Message { get; set; }
        public IDictionary<string, string[]> ModelState { get; set; }
    }
}