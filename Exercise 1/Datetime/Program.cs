using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.DateTime.Now);
            Console.WriteLine(System.DateTime.UtcNow);
            var nu = System.DateTime.Now();
            nu = nu.AddDays(-1);
            nu = new System.DateTime(1980, 01, 02);
            Console.WriteLine(nu);
            nu = nu.AddMinutes(20);
            TimeSpan diff = nu.Subtract(System.DateTime.Now);//Tids intervall
            nu = new System.DateTime(1980, 01, 02);
        }
    }
}
