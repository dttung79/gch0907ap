using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class DebitAccount : BankAccount
    {
        protected double limit;
        public double Limit
        {
            get { return limit; }
            set { limit = value; }
        }
        public DebitAccount(string name, double balance, int pin, double litmit) : base(name, balance, pin)
        {
            Limit = limit;
        }

        public override bool IsNotEnoughBalance(double amount)
        {
            double supposedBalance = balance - amount - GetWithdrawFee();
            if (supposedBalance < -limit)
            {
                Console.WriteLine("Not enough balance");
                return true;
            }
            return false;
        }

    }
}