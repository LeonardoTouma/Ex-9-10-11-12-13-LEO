using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerccize32
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.DoSomething();
            myclass.dosomethingelse();
            myclass.dosomethingmore();
            // hittar metoder ifrån båda de partial klasserna av myclass
                //-------------------------
                // uppgift 32 <-
                // kan skapa objekt och kolla ifall de är null med as och is
            object obj = new object();
            var obj1 = new object();
            var obj2 = new object();
            var user = new User();
            obj1 = obj as User;
            user = obj as User;
            obj2 = obj as Employee;
            obj = obj2 as User;
            if (obj == null)
            {
                Console.WriteLine("Obj is null");
            }
            else
            {
                Console.WriteLine("obj is inte null");
            }
            if (obj2 == null)
            {
                Console.WriteLine("obj2 is null");
            }
            else
            {
                Console.WriteLine("obj2 is null");
            }
            if (obj == null)
            {
                Console.WriteLine("obj1 is null");
            }
            else
            {
                Console.WriteLine("obj1 is null");
            }
           
            Console.ReadKey();
        }
    }
}
