using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Write in your name: ");
            var name = Console.ReadLine();
            Console.Write("Write in where you work: ");
            var work = Console.ReadLine();
            Console.Write("Write in your age: ");
            var age = Console.ReadLine();
            Console.Write("Write in your jobtitle: ");
            var title = Console.ReadLine();
            var birthdate = DateTime.Now.Year - int.Parse(age);
            Console.WriteLine("Hello " + name + " you are " + age + " years old " + " which means that you are born " + birthdate + " and work in " + work + ", where " + title + " is your jobtitle. ");
            Console.ReadKey();
        }
    }
}
