using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The letter Hello world contains: ");

            string numbLetters = "Hello World";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var letter in numbLetters)
            {
                if (dict.ContainsKey(letter.ToString()))
                {
                    dict[letter.ToString()] = dict[letter.ToString()] + 1;
                }
                else
                {
                    dict.Add(letter.ToString(), 1);
                }
            }
            foreach (var letter in dict)
            {
                Console.WriteLine("{0}:{1}", letter.Key, letter.Value);
            }
            Console.ReadLine();
        }
    }
}