using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace WpfApp1
{
    internal class Validator
    {

        public static bool Namevalid0(TextBox Name)
        {
            if (Name.Text.Length > 0)
                return true;
            else
                return false;
        }
        public static bool Namevalid(TextBox Name)
        {
            if (Name.Text.Length >= 3)
                return true;
            else
                return false;
        }

        public static bool Emailvalid0(TextBox Email)
        {
            if (Email.Text.Length > 0)
                return true;
            else
                return false;
        }

        public static bool Emailvalid(TextBox Email)
        {
            Regex regex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
            Match match = regex.Match(Email.Text);
            if (match.Success)
                return true;
            else
                return false;
        }

        public static bool Passvalid0(TextBox Name)
        {
            if (Name.Text.Length > 0)
                return true;
            else
                return false;
        }
        public static bool Passvalid(TextBox Name)
        {
            if (Name.Text.Length >= 6)
                return true;
            else
                return false;
        }
    }
}
