using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class VIPAccount : BankAccount
    {
        public VIPAccount(string name, double balance, int pin) : base(name, balance, pin)
        {
        }
        
        public override double GetWithdrawFee()
        {
            return 0;
        }
    }
}