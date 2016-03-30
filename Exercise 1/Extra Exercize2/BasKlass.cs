using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercize2
{
    class BasKlass
    {
        public int tal1 { get; set; }
        public int tal2 { get; set; }
        public int tal3 { get; set; }

       
        public void ÖverGripandeVariabler ()
        {
            Console.WriteLine("Skriv in 3 tal: ");
            Console.WriteLine("--------------------------------");
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.Write("Tal 3: ");
            int tal3 = int.Parse(Console.ReadLine());
            
        }
        
    }
}
