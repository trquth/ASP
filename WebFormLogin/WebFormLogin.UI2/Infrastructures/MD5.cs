using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormLogin.UI2.Infrastructures
{
    public sealed class MD5
    {
        public static string Hash(string value)
        {
            return BitConverter.ToString(System.Security.Cryptography.MD5.Create().ComputeHash(System.Text.Encoding.Default.GetBytes(value))).Replace("-", string.Empty).ToLower();
        }
    }
}
