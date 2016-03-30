using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Skriv in ett nummer: ");
            var tal = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= tal ; i++)
            {
                sum = sum + i;
                if (tal == i)
                {
                    
                    Console.Write(i);
                }
                else
                {
                    
                    Console.Write(i + " + ");
                }
               
               
            }
            Console.Write(" = " + sum);
            Console.ReadKey();
        }
    }
}
