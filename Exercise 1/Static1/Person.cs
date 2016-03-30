using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static1
{
    class Person
    {
        private static int _counter { get; set; }
        private int _index;
        public int index { get{ return _index; } }

        public Person ()
        {
            _index = _counter;
        }
    }
}
