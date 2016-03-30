using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize7
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Logger logger = new Logger();
            Lista lista = new Lista();
            bool result = true;
            Console.Clear();
            while (result)
            {
                Console.WriteLine(@" 1. Add employee
2. Remove employee
3. Print entire registry
4. Exit
Enter Your Choice: ");
                string Meny = Console.ReadLine();
                switch (Meny)
                {
                    case "1":
                        Console.Write("Skriv in ditt Förnamn: ");
                        var _FörNamn = Console.ReadLine();
                        Console.Write("Skriv in ditt Efternamn: ");
                        var _EfterNamn = Console.ReadLine();
                        Console.Write("Skriv in ditt SSN: ");
                        var _SSN = Console.ReadLine();
                        Console.Write("Skriv in ditt Timlön: ");
                        var _TimLön = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Employee employee = new Employee(_FörNamn, _EfterNamn, _SSN, _TimLön);
                        lista.AddEmployee(employee);
                        break;
                    case "2":
                        Console.WriteLine("Skriv in Ssn:et ");
                        string valAnvändare = Console.ReadLine();
                        Console.Clear();
                        lista.RemoveEmployee(valAnvändare);
                        Console.WriteLine("Den arbetaren är nu borta");
                        break;
                    case "3":
                        Console.WriteLine("Skriver ut registret");
                        var mylist = lista.GetAllEmployees();
                        foreach (var item in mylist)
                        {
                            Console.WriteLine(item.Firstname + item.Lastname + item.SocialsSecurityNumber + item.Hourlywage);
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Avslutad");
                        result = false;
                        break;

                }
                

            }
        }
    }
}
