using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize24
{
    class Weight
    {
        // FINNS PÅ PINGPONG
        public void SetWeight ()
        {
            
        }
        public void Add (Weightunits unit, double amount)
        {

        }
        private double GetFactor(Weightunits unit)
        {
            var result = 0.0;
            switch (unit)
            {
                default:
                    break;
            }
        }
        public double GetWeight(Weightunits units)
        {
            return weightKg * GetFactor(unit);
        }
    }
}
