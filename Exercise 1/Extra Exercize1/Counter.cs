using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercize1
{
    class Counter
    {
        public int GetHello(string[] texts)
        {
            int sum = 0;
            foreach (string item in texts)
            {
                if (item == "Hello")
                {
                    sum++;
                }

            }
            return sum;
        }
    }
}
