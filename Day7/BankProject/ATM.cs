using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class ATM
    {
        private BankManager bank;

        public void ChangePin()
        {
            // ask user for account id
            Console.WriteLine("Enter account id: ");
            int id = int.Parse(Console.ReadLine());
            // ask user for old pin
            Console.WriteLine("Enter old pin: ");
            int oldPin = int.Parse(Console.ReadLine());
            // ask user for new pin
            Console.WriteLine("Enter new pin: ");
            int newPin = int.Parse(Console.ReadLine());
            foreach (BankAccount account in bank.Accounts)
            {
                if (account.ID == id)
                {
                    account.ChangePin(oldPin, newPin);
                    return;
                }
            }
            {
                
            }
        }
    }
}