using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercize2
{
    class Program
    {
        static void Main(string[] args)
        {
            BasKlass Basklass = new BasKlass();
            Minsta_talet RäknaUtMinstaTalet = new Minsta_talet();
            Största_talet RäknaUtStörstaTalet = new Största_talet();
            Basklass.ÖverGripandeVariabler();
            RäknaUtMinstaTalet.MinstaTalet();
            RäknaUtStörstaTalet.StörstaTalet();
            Console.ReadKey();
        }
    }
}
