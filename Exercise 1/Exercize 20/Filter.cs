using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_20
{
    class Filter
    {
        public List<string> Search (List<string> inputList, string Searchterm)
        {
            List<string> result = new List<string>();

            foreach (var item in inputList)
            {
                if (item.ToUpper().Contains(Searchterm.ToUpper()))
                    result.Add(item);
            }

            return result;
        }
    }
}
