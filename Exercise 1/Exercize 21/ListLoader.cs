using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_21
{
    class ListLoader
    {
        public List<LanguageData> LoadData()
        {
            var result = new List<LanguageData>();

            var reader = new StreamReader("Languages.txt");
            string line;
            while ((line = reader.Readline()) != null)
            {
                var name = line.Split ()
            }
            return result;
        }
    }
}
