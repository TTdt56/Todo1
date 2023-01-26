using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Validator
    {
        public static string Passvalid(string pass)
        {
            if (pass.Length >= 7)
            {
                return null;
            }
            return "error";
        }
    }
}
