using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize12
{
    class DateTimeLogger : ILogger
    {
        public List<string> LogPosts { get; set; }
        void ILogger.Log(string message)
        {
            
        }

        void Log(string message)
        {

        }
       
    }
}
