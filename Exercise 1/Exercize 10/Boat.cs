using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_10
{
    class Boat : Vehicle
    {

        public Boat(string TypOfVehicale): base ("Boat")
        {
            this.TypeOfVehicale = TypeOfVehicale;
        }
    }
}
