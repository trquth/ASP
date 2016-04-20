using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormLogin.UI2.Infrastructures
{
    public static class ObjectExtension
    {
        public static bool IsNull(this object obj)
        {
            if (obj == null || DBNull.Value == obj)
                return true;
            return false;
        }
        public static bool IsNotNull(this object obj)
        {
            return !IsNull(obj);
        }
    }
}
