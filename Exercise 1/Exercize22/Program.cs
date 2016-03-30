using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize22
{
    class Program
    {
        static void Main(string[] args)
        {
            Cordinate cord1 = new Cordinate();
            cord1.x = 5;
            cord1.y = 5;

            Cordinate cord2 = cord1;

            cord2.x = 30;
            cord2.y = 30;
            Console.WriteLine($"Cord1.x  {cord1.x}, Cord1.y = {cord1.y}");
            Console.WriteLine($"Cord2.x  {cord2.x}, Cord2.y = {cord2.y}");
        }
    }
}
