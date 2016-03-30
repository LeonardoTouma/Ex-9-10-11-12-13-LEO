using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familj1
{
    class Föräldrer:IFarföräldrar
    {
        public string HårFärg { get; set; }
        public bool Hoppa { get; set; }

        public int Ålder { get; set; }

        private string choice = "";

        public Föräldrer(string _HårFärg, bool _Hoppa, int _Ålder )
        {
            this.HårFärg = _HårFärg;
            this.Hoppa = _Hoppa;
            this.Ålder = _Ålder;
        }
        public string hoppa(string Ja, string Nej)
        {
            Console.WriteLine("Så vad tror du, tror du att barnet kan hoppa Ja/Nej? ");
            if (choice == Ja)
            {
                Console.WriteLine("Barnet kan tyvärr inte hoppa");
            }
            else
            {
                Console.WriteLine("Barnet kan hoppa");
            }
            return choice;
        }
    }
}
