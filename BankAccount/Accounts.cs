using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Accounts
    {
        private decimal checkingaccountbalance;
        public decimal Checkingaccountbalance
        {
            get { return checkingaccountbalance; }
            set { checkingaccountbalance = value; }
        }

        private decimal savingsaccountbalance;

        public decimal Savingsaccountbalance
        {
            get { return savingsaccountbalance; }
            set { savingsaccountbalance = value; }
        }
 
    }
}
