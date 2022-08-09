using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class NormalAccount : BankAccount
    {
        public NormalAccount(string name, double balance, int pin) : base(name, balance, pin)
        {
        }
    }
}