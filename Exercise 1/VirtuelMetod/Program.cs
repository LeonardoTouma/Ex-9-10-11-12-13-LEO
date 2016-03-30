using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelMetod
{
     abstract class vehicale
    {
        public int power { get; set; }
        public virtual void Drive ()
        {

        }
        class Car : vehicale
        {
            // Override här men virtual i Basklassen
            public override void Drive ()
            {
                //Kallar på en specifik funktion
                //base.Drive();
            }
            class Garage
            {
                List<vehicale> _list = new List<vehicale>();
                public void AddVehical (vehicale vehicale)
                {
                    _list.Add(vehicale);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Objektet är skapat utav en abstrakt klass
            //var MyVehical = new vehicale();
            var Mycar = new Car();
            var Mygarage = new Garage();
            Mygarage.AddVehical(mycar);
            // Finns hela på pingpong som är direkt skriven av läraren
        }
    }
}
