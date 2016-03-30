using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData VD = new VehicleData();
            Car Car = new Car("");
            Boat boat = new Boat("");
            VD.PrintVehicle();
            Console.WriteLine(@"Vill du välja: 
1) Bil
2) Båt ");

            string meny = Console.ReadLine();
            switch (meny)
            {
                case "1":
                    Console.WriteLine(Car.TypeOfVehicale);
                    Console.WriteLine("");
                    break;
                case "2":
                    Console.WriteLine(boat.TypeOfVehicale);
                    break;
            }
            Console.ReadKey();
           
        }
    }
}
