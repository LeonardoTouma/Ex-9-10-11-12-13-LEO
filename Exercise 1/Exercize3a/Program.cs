using System;


namespace Exercize3b
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välj en operator");
                Console.WriteLine("A.Addition(+)");
                Console.WriteLine("B. Minus (-)");
                Console.WriteLine("C. Multiplikation (*)");
                Console.WriteLine("D. Delat med (/)");
                char Operator = char.Parse(Console.ReadLine());
                Console.WriteLine("----------------------");
                Console.WriteLine("Enter the first number: ");
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int tal2 = int.Parse(Console.ReadLine());
                int sum = tal1 + tal2;
                switch (Operator)
                {
                    case 'A':
                        Console.WriteLine();
                        sum = tal1 + tal2;
                        break;
                    case 'B':
                        Console.WriteLine();
                        sum = tal1 - tal2;
                        break;
                    case 'C':
                        Console.WriteLine();
                        sum = tal1 * tal2;
                        break;
                    case 'D':
                        Console.WriteLine();
                        sum = tal1 / tal2;
                        break;
                        Console.WriteLine();
                    default:
                        Console.WriteLine("Du valde inte något av de valen, du fick ");
                        break;
                }
                Console.WriteLine("Första talet: " + tal1 + "\nOperator: " + Operator + "\nAndra talet: " + tal2 + "\nSumman: " + sum);
                
                Console.WriteLine("\n Do you want to make another calculation? (y/n) ");
                
                string InPut = Console.ReadLine();
                if (InPut == "y")
                {
                    
                }
                else
                {
                    
                    break;
               
                }
                
            }
        }
    }
}
