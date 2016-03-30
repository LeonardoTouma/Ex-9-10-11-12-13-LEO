using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAtm
{
    class Meny1
    {
        public void meny()
        {
            bool run = true;
            var account = new Account();


            while (run)
            {
                // Print main menu
                Console.Clear();
                Console.WriteLine("Select an option");
                Console.WriteLine("----------------");
                Console.WriteLine();
                Console.WriteLine("a) Withdraw from account");
                Console.WriteLine("b) Deposit to account");
                Console.WriteLine("c) Check balance");
                Console.WriteLine("d) Exit");
                Console.WriteLine();

                // Collect user input
                Console.Write("> ");
                var input = Console.ReadLine();
                Balance balance = new Balance();
                switch (input)
                {
                    case "a": // The user selected "Withdraw from account"
                        account.Withdraw(0);
                        break;

                    case "b":
                        account.Deposit(0);
                        break;

                    case "c":
                        Console.WriteLine("You have: " + balance.GetBalance() + "SEK");
                        break;

                    case "d":
                        run = false;
                        Console.WriteLine("Bye!");
                        break;
                }

                Console.ReadKey();
            }
        }       
    }
}
