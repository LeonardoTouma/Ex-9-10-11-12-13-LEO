using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_3aA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal! ");
            int tal = int.Parse(Console.ReadLine());
            var i = 1;
            var sum = 0;
            while (i <= tal)
            {
                sum += i;
                i++;
                Console.Write(i);


                if (tal > i)
                {
                    Console.Write(i + " + " + sum);
                }
                else
                {
                    Console.Write(i + " = " + sum);
                }
                
            }
            Console.ReadKey();
        }
    }
}
