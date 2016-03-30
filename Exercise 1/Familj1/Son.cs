using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familj1
{
    class Son: Föräldrer
    {

        public Son(string _HårFärg, bool _Hoppa, int Ålder) : base(_HårFärg, _Hoppa, Ålder)
        {
            this.Hoppa = Hoppa;
            this.HårFärg = HårFärg;
        }
        public string Hårfärg(string Hårfärg)
        {
            HårFärg = "Brunt";
            return Hårfärg;
        }
        public int Ålder (int _Ålder)
        {
            _Ålder = 15;
            return _Ålder;
        }
        public bool HOPPA (bool hoppa)
        {
            if (Hoppa)
            {
                Console.WriteLine("Han kan hoppa! ");
            }
            else
                Console.WriteLine("Han kan inte hoppa! ");
            return Hoppa;
        }
    }
}
