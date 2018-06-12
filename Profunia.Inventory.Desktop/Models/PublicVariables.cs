using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profunia.Inventory.Desktop.Models
{
    internal class PublicVariables
    {
        public static decimal _decCurrentUserId = 1m;

        public static decimal _decCurrentCompanyId = 0m;

        public static DateTime _dtCurrentDate;

        public static DateTime _dtFromDate;

        public static DateTime _dtToDate;

        public static decimal _decCurrentFinancialYearId = 1m;

        public static bool isMessageAdd = true;

        public static bool isMessageEdit = true;

        public static bool isMessageDelete = true;

        public static bool isMessageClose = true;

        public static decimal _decCurrencyId = 1m;

        public static int _inNoOfDecimalPlaces = 2;

        public static string MessageToShow = string.Empty;

        public static string MessageHeadear = string.Empty;
    }
}
