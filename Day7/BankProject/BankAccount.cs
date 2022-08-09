using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public abstract class BankAccount
    {
        // static count
        private static int count = 0;
        // ID
        private int id;
        public int ID 
        {
            get { return id; }
        }
        // Balance
        private double balance;
        public double Balance
        {
            get { return balance; }
        }

        // Name
        public string Name { get; set; }
        private int pin;
        public int PIN 
        {
            get { return pin; }
        }

        protected const int WITHDRAW_FEE = 0.05;


        public BankAccount(string name, double balance, int pin)
        {
            id = count++;
            Name = name;
            this.balance = balance;
            this.pin = pin;
        }
        public void Deposit(double amount)
        {
            if (IsNegativeAmount(amount)) return;

            balance += amount;
            Console.WriteLine("Deposit successful");
        }

        protected bool IsNegativeAmount(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
                return true;
            }
            return false;
        }

        public abstract void Withdraw(double amount);

        public bool ChangePin(int oldPin, int newPin)
        {
            if (oldPin != pin)
            {
                Console.WriteLine("Invalid pin");
                return false;
            }
            pin = newPin;
            Console.WriteLine("Pin changed successfully");
            return true;
        }

        protected virtual double GetWithdrawFee(double amount)
        {
            return WITHDRAW_FEE * amount;
        }

        public override void Withdraw(double amount)
        {
            if (IsNegativeAmount(amount)) return;

            if (IsNotEnoughBalance(amount))

            balance -= (amount + GetWithdrawFee());
            Console.WriteLine("Withdraw successful");
        }
        protected virtual bool IsNotEnoughBalance(double amount)
        {
            double supposedBalance = balance - amount - GetWithdrawFee();
            if (supposedBalance < 0)
            {
                Console.WriteLine("Insufficient balance");
                return true;
            }
            return false;
        }
    }
}