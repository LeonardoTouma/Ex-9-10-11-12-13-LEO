using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Write in the year you were born ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Write in the month you were born");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Write in what day you were born ");
            int day = int.Parse(Console.ReadLine());
            DateTime BirthDay = new DateTime(year,month,day);
            DateTime today = DateTime.Today;
            DateTime Nextbirthday = new DateTime(today.Year, month, day);
            TimeSpan age = today - BirthDay;
            TimeSpan NextBirthday = Nextbirthday - today;
            DateTime hundred = new DateTime((year + 100),month, day );
            
          
            Console.WriteLine("Hello there " + name);
            Console.WriteLine("You are born in " + "year: " + year + " - " + "Month: " + month + " - " + "day " + day);
            Console.WriteLine("You are " + (int)(age.Days/365.25));
            Console.WriteLine("Your next birthday is in " );
        }
    }
}
