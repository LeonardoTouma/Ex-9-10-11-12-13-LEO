using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAtm
{
    class Account
    {
        private int balance = 0;
        // Withdraw money from account

        public void Withdraw(int amount)
        {
            Console.WriteLine("Enter amount: ");
           amount = int.Parse(Console.ReadLine());

            if (balance >= amount)
            {
                Console.WriteLine("Withdrawing {0} SEK from account", amount);
                balance -= amount;
            }
            else
            {
                Console.WriteLine("You don't have {0} SEK to withdraw", amount);
            }

        }
        // Deposit money to account
        public void Deposit(int amount)
        {
            Console.WriteLine("Enter amount: ");
            amount = int.Parse(Console.ReadLine());

            balance += amount;
            Console.WriteLine("Depositing {0} SEK to account", amount);
        }
    }
}
