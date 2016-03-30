using System;
using System.Threading;

namespace ConsoleRenderer
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var xSize = 70;
            var ySize = 25;

            //Console.SetWindowSize(150, 60);

            var game = new GameState(xSize, ySize, new GameOfLifeRule());
            Populate(game.GameBoard);


            while (true)
            {
                foreach (var row in game.GameBoard.Rows)
                {
                    foreach (var cell in row)
                    {
                        if (cell.State == State.Alive)
                        {
                            Console.Write("#");
                        }
                        if (cell.State == State.DeadOrEmpty)
                        {
                            Console.Write(" ");
                        }
                    }
                   Console.Write(Environment.NewLine);
                }

                Console.WriteLine("Generation: " + game.Generation);
                //Thread.Sleep(new TimeSpan(0, 0, 0, 0, 100));

                game.Step();
                Thread.Sleep(100);
                Console.Clear();
                //Console.SetCursorPosition(0, 0);
            }
        }

        public static void Populate(GameBoard board)
        {
            var max = board.Width * board.Height;
            var alive = max / 4;

            var rnd = new Random();

            for (var count = 0; count < alive; count++)
            {
                var x = rnd.Next(0, board.Width);
                var y = rnd.Next(0, board.Height);

                board.SetCellState(new Location(x, y), State.Alive);
            }
        }
    }
}