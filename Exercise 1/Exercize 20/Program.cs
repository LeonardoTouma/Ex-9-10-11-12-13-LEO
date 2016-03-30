using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercize_20
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListLoader = new ListLoader();
            var mylist = ListLoader.Load();

            Console.Write("Enter search term: ");
            string Searchterm = Console.ReadLine();
            var filter = new Filter();
            var filterdlist = filter.Search(mylist, Searchterm);

            foreach (var item in filterdlist)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
