using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            point korva = new point { X = 7, Y = 5 };
            
        }
        struct point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        class Kordinater
        {
            public Kordinater (Kordinater c1, Kordinater c2, Kordinater c3)
            {
                
            }
            public void print ()
            {
                Console.WriteLine();
            }
        }

    }
}
