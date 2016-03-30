using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_25
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyProcess = new Process();
            Console.WriteLine("Current state: " + MyProcess.currentState);
            MyProcess.Start();
            Console.WriteLine("Current state: " + MyProcess.currentState);
            MyProcess.Pause();
            Console.WriteLine("Current state " + MyProcess.currentState);
            MyProcess.Stop();
            Console.ReadKey();
        }
    }
}
