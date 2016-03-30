using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_10
{
    class Vehicle
    {
        public string TypeOfVehicale { get; set; }


        public Vehicle (string TypeOfVehicale)
        {
            this.TypeOfVehicale = TypeOfVehicale;
           
        }
        public string DescribeVehicle ()
        {
            return ("This is an: " + TypeOfVehicale);
        }

    }
}
