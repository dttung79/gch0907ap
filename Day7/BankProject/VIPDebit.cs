using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class VIPDebit : DebitAccount
    {
        public VIPDebit(string name, double balance, int pin, limit) : base(name, balance, pin, limit)
        {
        }
        public override double GetWithdrawFee()
        {
            return 0;
        }
    }
}