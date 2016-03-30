using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize12
{
   class Logger:ILogger
    {
        public List<string> LogPosts { get; set; }



        public void Log(string message)
        {
            LogPosts.Add(message);
        }

        public Logger()
        {
            LogPosts = new List<string>();
        }
    }
}
