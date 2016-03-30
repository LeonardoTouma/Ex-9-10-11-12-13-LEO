using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_översättning
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("katt", "Cat");
            dict.Add("Hund", "Dog");
            dict.Add("Mus", "Mouse");

            string svenska = "Jag tycker om Katt, Hund, Mus men inte fågel";

            List<string> words = GetWordsFromString(svenska);
            List<string> translated = Translate(words, dict);
            string result = BuildString(translated);
            Console.WriteLine(svenska);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static string BuildString(List<string> translated)
            
        {
            string result = "";
            foreach (var word in translated)
            {
                result.Append(word);
                //-.-
            }
            return result;
            //StringBuilder result = new StringBuilder();
            //////....
            //return result.ToString();
        }

        private static List<string> Translate(List<string> words, Dictionary<string, string> dict)

        {
            var result = new List<string>();
            foreach (var word in words)
            {
               
                if (dict.ContainsKey (word.ToLower()))
                {
                    result.Add(dict[word.ToLower()]);
                }
                else
                {
                    result.Add(word);
                }
                
            }
            return result;
        }
        

        private static List<string> GetWordsFromString(string svenska)
        {
            var words = svenska.Split(new char[] { ' ', ','});
            return words.ToList();
        }
    }
}
