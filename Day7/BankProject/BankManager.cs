using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class BankManager
    {
        private List<BankAccount> accounts;
        public List<BankAccount> Accounts
        {
            get { return accounts; }
        }
    }
}