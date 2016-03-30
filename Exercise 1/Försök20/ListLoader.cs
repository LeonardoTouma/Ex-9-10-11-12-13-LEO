using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Försök20
{
    class ListLoader
    {
        public List<string> Load ()
        {
            List<string> result = new List<string>();
            StreamReader reader = new StreamReader("Language.txt");

            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                result.Add(line);
            }
            reader.Close();
            return result;
        }
    }
}
