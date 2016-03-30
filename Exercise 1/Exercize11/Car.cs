using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_11
{
    class Car : Vehicle
    {
        public Car(string TypOfVehicale) : base("Car")
        {
            var engineIsRunning = false;
        }
        public void StartEngine(bool engineIsRunning)
        {
            engineIsRunning = true;
        }
        public void StopEngine(bool engineIsRunning)
        {
            engineIsRunning = false;
        }
    }
}
