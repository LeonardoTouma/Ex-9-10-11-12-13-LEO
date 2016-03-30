using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAtm
{
    class Balance
    {
        private int balance = 0;
        public int GetBalance()
        {
            return balance;
        }
        public void SetBalance(int balance)
        {
            this.balance = balance;

        }
    }
 }
