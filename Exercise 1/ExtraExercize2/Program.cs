using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercize2
{
    class Program
    {
        static void Main(string[] args)
        {
            Largest_number LargeNumb = new Largest_number();
            Smallest_Number SmallNumb = new Smallest_Number();
            Console.WriteLine("Skriv in 3 nummer");
            Console.Write("Nummer 1: ");
            var numb1 = int.Parse(Console.ReadLine());
            Console.Write("Nummer 2: ");
            var numb2 = int.Parse(Console.ReadLine());
            Console.Write("Nummer 3: ");
            var numb3 = int.Parse(Console.ReadLine());
            LargeNumb.LargestNumber(4,1,2);
            SmallNumb.SmallestNumber(1,2,3);



            Console.ReadKey();
        }
    }
}
