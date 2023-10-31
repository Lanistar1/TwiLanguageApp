using System;
using System.Collections.Generic;
using System.Text;

namespace TwiApp.Helpers
{
    public static class Global
    {


        public static bool Contains(this string target, string value, StringComparison comparison)
        {
            return target.IndexOf(value, comparison) >= 0;
        }
    }
}
