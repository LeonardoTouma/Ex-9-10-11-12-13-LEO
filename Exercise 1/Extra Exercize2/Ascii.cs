﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercize2
{
    class Ascii
    {
        public void ascii()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }
}
