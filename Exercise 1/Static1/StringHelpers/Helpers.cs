using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static1.Helpers
{
    class Helpers
    {
        public static int GetNumberOfLetters(string input)
        {
            int result = 0;
            result = input.Length;
            return result;
        }
        public static int GetNumberOfWords (string input)
        {
            int result = 0;
            result = input.Split(' ').Length;

            return result;
        }
    }
}
