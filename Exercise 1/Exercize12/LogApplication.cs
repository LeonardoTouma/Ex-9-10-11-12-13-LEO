using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize12
{
    class LogApplication
    {
        private ILogger _logger;
        public LogApplication(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            Console.WriteLine("1) Add Message ");
            Console.WriteLine("2) Print log ");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                
                Console.Write("Add the message: ");
                string Message = Console.ReadLine();
                _logger.Log(Message);
            }
           else if (Choice == 2)
            {
                foreach (var item in _logger.LogPosts)
                {
                    Console.WriteLine(item);
                }
               
            }
            
        }
    }
}
