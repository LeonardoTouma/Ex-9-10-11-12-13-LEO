using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercize2
{
    class Största_talet:BasKlass
    {
       
        public void StörstaTalet ()
        {
            if (tal1 > tal2 && tal1 > tal3)
            {
                Console.WriteLine("Det första talet du skrev är störst " + tal1);
            }
            else if (tal2 > tal1 && tal2 > tal3)
            {
                Console.WriteLine("Det andra talet du skrev är störst " + tal2);
            }
            else if (tal3 > tal1 && tal3 > tal2)
            {
                Console.WriteLine("Det tredje talet du skrev är störst: " + tal3);
            }

        }
    }
}
