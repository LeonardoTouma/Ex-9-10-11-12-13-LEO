using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize23b
{
    class Program
    {
        static void Main(string[] args)
        {
            Cordinates? c1 = new Cordinates { x = 7, y = 5 };
            Cordinates? c2 = new Cordinates { x = 5, y = 5 };
            Cordinates? c3 = new Cordinates { x = 25, y = 30 };
            triangle myTriangle = new triangle(c1.Value, c2.Value, c3.Value);
            Cordinates c4 = c1.Value;// för att ge c1 ett värde så sätter c1 till c4 för att instansen ska kunna jobba med kordinaterna
            c4.x = 20;
            c4.y = 20;
            c1 = new Cordinates { x = 20, y = 20 };
            if (c1.HasValue && c2.HasValue && c3.HasValue)
            {
                triangle mytriangle = new triangle(c1.Value, c2.Value, c3.Value);
            }

            c1.Value.set(20, 20);
            // 
        }
        class triangle
        {
            public triangle(Cordinates c1, Cordinates c2, Cordinates c3)
            {

            }
        }
        struct Cordinates
        {
            public int x { get; set; }
            public int y { get; set; }

            public void set (int x, int y)
            {
               
            }
        }
    }
}
