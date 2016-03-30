using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercize2
{
    class Value
    {
        public void value()
        {
            int i;
            int[] A = { 10, 55, 9, 4, 234, 20, 30, 40, 22, 34 };
            int max = A[0];
            int min = A[0];
            for (i = 0; i < 10; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                else if (A[i] < min)
                {
                    min = A[i];
                }
            }
            Console.ReadKey();
        }
        public int GetMaxValueFromArray ()
        {

            Console.WriteLine("Maximum value in the array : " + max);
            return GetMaxValueFromArray;
        }
        public int GetMinValueFromArray()
        {
            Console.WriteLine("Minimum value in the array : " + min);
            return GetMinValueFromArray;
        }
        public int CalculateAverageValueFromArray()
        {

        }
    }
}
