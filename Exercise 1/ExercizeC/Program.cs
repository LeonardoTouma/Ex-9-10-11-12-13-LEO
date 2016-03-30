using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercizeC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input what kind of product: ");
            string product = Console.ReadLine();
            Console.Write("What is the price of that product: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("What is the quantity of what you are buying: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.WriteLine("Is it food or something else? y/n: ");
            string food = Console.ReadLine();
            if (food == "y")
            {
                double tax;
                double sum;
                sum = price * quantity;
                tax = sum * 0.1;
                double res = sum + tax;
                Console.WriteLine("Including tax: " + res);
                Console.WriteLine("Excluding tax: " + sum);
                Console.WriteLine("Tax is: " + tax);
            }
            else
            {
                double sum;
                double tax;
                sum = price * quantity;
                tax = sum * 0.25;
                double res = sum + tax;
                Console.WriteLine("Including tax: " + res);
                Console.WriteLine("Excluting tax: " + sum);
                Console.WriteLine("Tax is: " + tax);
            }
            
            Console.ReadKey();

        }
    }
}
