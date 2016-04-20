using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormLogin.UI2.Infrastructures
{
    public static class StringExtension
    {
        public static bool StringIsNullEmptyWhiteSpace(this string obj)
        {
            if (string.IsNullOrEmpty(obj) || (string.IsNullOrWhiteSpace(obj)))
                return true;
            return false;
        }
    }
}
