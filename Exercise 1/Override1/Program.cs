using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Gameover = false;
            var player = new Player() { x = 10, y = 10 };
            do
            {

                PrintGame(player);

                ConsoleKeyInfo key = GetPlayerInput();
            } while (!Gameover);

            Console.SetCursorPosition(2,0);
            Console.Write("x");

            Console.ForegroundColor = ConsoleColor.Red;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                    Console.WriteLine("Höger");
                    break;
                    case ConsoleKey.LeftArrow:
                    Console.WriteLine("Vänster");
                    break;
                    case ConsoleKey.UpArrow:
                    Console.WriteLine("Upp");
                    break;
                    case ConsoleKey.DownArrow:
                    Console.WriteLine("ner");
                    break;

                }
            }
        }

        private static ConsoleKeyInfo GetPlayerInput()
        {
            throw new NotImplementedException();
        }

        public class Player
        {
            public int x;
            public int y;
            public bool IsDead;
        }
        private static void PrintGame (Player player)
        {
            Console.Clear();
            Console.SetCursorPosition(player x, player y);
            Console.ForegroundColor(ConsoleColor.Red);
        }
    }
}
