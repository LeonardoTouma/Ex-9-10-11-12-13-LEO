using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
           
        public enum process
           
        {
            Running,
            Pause,
            Stop,
        }
        public process Running { get; set; }
        public process Pause { get; set; }
        public process Stop { get; set; }
    }
}
