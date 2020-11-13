using System;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsFirstPlayer = int.Parse(Console.ReadLine());
            int eggsSecondPlayer = int.Parse(Console.ReadLine());

            string winner = Console.ReadLine();
            bool looseGame = false;

            while (winner != "End of battle")
            {
                if (winner == "one")
                {
                    eggsSecondPlayer--;
                }
                else
                {
                    eggsFirstPlayer--;
                }

                if (eggsFirstPlayer == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecondPlayer} eggs left.");
                    looseGame = true;
                    break;
                }

                if (eggsSecondPlayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirstPlayer} eggs left.");
                    looseGame = true;
                    break;
                }

                winner = Console.ReadLine();
            }

            if (!looseGame)
            {
                Console.WriteLine($"Player one has {eggsFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {eggsSecondPlayer} eggs left.");
            }

        }
    }
}
