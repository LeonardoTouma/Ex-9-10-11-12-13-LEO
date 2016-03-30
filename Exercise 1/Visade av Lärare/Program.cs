

using System;

namespace Visade_av_Lärare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world (namespace)");

            //bool flag = false;

            //while (flag)
            //{
            //    Console.WriteLine("I'm in the while - loop");
            //}
            //do
            //{
            //    Console.WriteLine("Im in the Do_While loop");
            //} while (flag);
            //{

            //}
            //Console.ReadKey();

            //Console.Write("");
            //var myYear = int.Parse(Console.ReadLine());
            //DateTime birthDate = DateTime.Parse(Console.ReadLine());
            //TimeSpan age = DateTime.Now - birthDate;
            //int years = age.Days / 365;
            //// Istället för att skriva så här:
            //Console.WriteLine("");
            /*Så här kan man skriva  (String interpretetion)
            Detta är för att man har tagit bort:
            console.writeline("Years = {1}, amount = 0,")
            */
            int years = 50;
            int amount = 100;
            Console.WriteLine($"Years = {years}, amount = {amount}");
            Console.WriteLine($"You are {years} Years old!");
            Account1 myAccount = new Account1();
            myAccount.DepositMoney(1);
            myAccount.DepositMoney(1, 200);
            Console.ReadKey();
        }
    }
}
