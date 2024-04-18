using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VincesGarage.Extensions
{
    public static class StringExtensions
    {
        public static string Swifify(this string str)
        {
            if (str == null)
            {
                return null;
            }

            return "Taylor said " + str;
            
        }

    }
}
