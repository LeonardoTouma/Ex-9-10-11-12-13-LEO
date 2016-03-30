using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize23
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cordinate cordi = new Cordinate();
            var ChEmployee = new CheckBox { Description = "Employee" };
            if (ChEmployee.Checked.HasValue)
            {
                var IsChecked = ChEmployee.Checked.Value;
                if (IsChecked)
                {
                    Console.WriteLine("Employee is checked");
                }
                else
                {
                    Console.WriteLine("Employee is not checked");
                }
            }
            else
            {
                Console.WriteLine("Value not set on employee checkbox! ");
            }
        }
    }
}
