using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_11
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData VD = new VehicleData();
            Car Car = new Car("");
            Boat boat = new Boat("");
            VD.PrintVehicle();
            Console.WriteLine(@"Choose one: 
1) Car
2) Boat ");

            string meny = Console.ReadLine();
            switch (meny)
            {
                case "1":
                    Console.WriteLine(Car.TypeOfVehicale);
                    break;
                case "2":
                    Console.WriteLine(boat.TypeOfVehicale);
                    break;
            }
            Console.ReadKey();
        }
        
    }
}

