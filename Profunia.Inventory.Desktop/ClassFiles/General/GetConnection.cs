using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profunia.Inventory.Desktop.ClassFiles.General
{
    internal class GetConnection : DBConnection
    {
        internal string GetCurrentConnctionString()
        {
            string ss = base.sqlcon.ConnectionString;
            if (ss.Contains("user id='"))
            {
                ss = ss + ";password='" + base.password + "'";
            }
            return ss;
        }
    }
}
