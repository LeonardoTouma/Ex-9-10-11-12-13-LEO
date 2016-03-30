using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familj1
{
    class Meny
    {
        public Föräldrer föräldrar { get; set; }
        public Meny(Föräldrer föräldrar)
        {
            this.föräldrar = föräldrar;
        }
        public void _meny()
        {

            Console.WriteLine("Tryck 1: \nHär kollar du om personen kan hoppa eller inte ");
            Console.WriteLine("Tryck 2: \nVilken Hårfärg personen har");
            Console.WriteLine("Tryck 3: \nHur gammal personen är");

            string choice = Console.ReadLine();
            bool result = true;
            while (result)
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Här kollar du om personen kan hoppa eller inte");
                        
                        break;
                    case "2":
                        Console.WriteLine("Vilken Hårfärg personen har: ");

                        break;
                    case "3":
                        Console.WriteLine("Hur gammal personen är: ");
                      
                        break;
                    default:
                        Console.WriteLine("Du valde ingen av de valen du gavs");

                        break;

                }
                result = false;

            }
        }
    }
}
