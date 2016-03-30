using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize26
{
    class Calculator
    {
        static int memory = 0;   
        private static int Memory { get { return memory; } }
        public static int Add(int a, int b)
        {

            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public void Add (int a)
        {
            memory += a;
        }
        public void Subtract (int a)
        {
            memory -= a;
        }
    }
}
