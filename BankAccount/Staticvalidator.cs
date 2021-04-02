using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Staticvalidator
    {
        public static bool ISelected(int selectedIndex)
        {
            if (selectedIndex==-1)
            {
                return false;
            }
            return true;
        }
        public static bool IsDecimal(string text)
        {
            decimal num = 0m;

            if (!decimal.TryParse(text, out num))
            {
                return false;
            }
            return true;
        }      
    }   

}
