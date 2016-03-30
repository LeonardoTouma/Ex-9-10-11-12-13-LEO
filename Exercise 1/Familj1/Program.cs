using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Föräldrer förälder = new Föräldrer("", true, 1);
            Meny meny = new Meny(förälder);
            meny._meny();
            Son son = new Son("", false, 1);
            Dotter dotter = new Dotter("", true, 2);
           


        }
        

    }
}
