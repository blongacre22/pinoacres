using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinoacres.BusinessObjects
{
    public static class StringExtensions
    {
        public static int ToInt(this string value)
        {
            int output = 0;
            int.TryParse(value, out output);
            return output;
        }

        public static bool ToBool(this string value)
        {
            bool output = false;
            bool.TryParse(value, out output);
            return output;
        }
    }
}
