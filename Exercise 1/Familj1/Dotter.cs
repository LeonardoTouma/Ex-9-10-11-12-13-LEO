using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familj1
{
    class Dotter : Föräldrer
    {
        public Dotter(string BlontHår, bool Hoppa, int Ålder) : base(BlontHår, Hoppa, Ålder)
        {
            if (Hoppa)
            {
                Console.WriteLine("Hon kan hoppa! ");
            }
            else
                Console.WriteLine("Hon kan inte hoppa! ");
        }
    }
}
