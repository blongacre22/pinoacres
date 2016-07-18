using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinoacres.BusinessObjects
{
    public static class DateExtensions
    {
        public static bool IsLastDayOfYear(this DateTime date)
        {
            return date.DayOfYear > 364;
        }
    }
}
