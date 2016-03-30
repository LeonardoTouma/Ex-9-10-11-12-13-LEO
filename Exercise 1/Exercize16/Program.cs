using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;using System.Collections;
namespace Exercize16
{
    class Program
    {
        static void Main(string[] args)
        {
           
        Stopwatch stopwatch = new Stopwatch();
            ArrayList arraylist = new ArrayList();
            stopwatch.Start();
            for (int i = 0; i< 100000; i++)
            {
                
                arraylist.Add(i);
                
                
            }
            Console.WriteLine("Arraylist took: {0} ",stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();
            stopwatch.();
            List<int> mylist = new List<int>();
            stopwatch.Start();
            for (int y = 0; y < 100000; y++)
            {

                mylist.Add(y);
               

            }
            Console.WriteLine("GenericList took: {0} ", stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();
            Console.ReadKey();
        }
    }
}
