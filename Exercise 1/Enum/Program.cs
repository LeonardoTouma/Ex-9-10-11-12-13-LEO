using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            var colorValue = (int)ConsoleColor.Red;
            Console.WriteLine("ColorValue " + colorValue);
            

            foreach (var item in Enum.GetValues(typeof(ConsoleColor)));
            {
                Console.WriteLine($"{item} = {(int) item}");
            }


            Card myCard = new Card(Card.SuitEnum.Hearts);
            switch (myCard.suit)
            {
                case Card.SuitEnum.Hearts:
                    break;
                case Card.SuitEnum.Clubs:
                    break;
                case Card.SuitEnum.Diamonds:
                    break;
                case Card.SuitEnum.Spades:
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            //Enum.GetValues (typeof (consolecolor))
        }
    }
}
