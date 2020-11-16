using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingEggs = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            bool notEnoughEggs = false;
            int eggsSold = 0;

            while (command != "Close")
            {
                int eggs;
                if (command == "Buy")
                {
                    eggs = int.Parse(Console.ReadLine());
                    eggsSold += eggs;
                }
                else
                {
                    eggs = int.Parse(Console.ReadLine()) * -1;
                }

                if (startingEggs < eggs )
                {
                    notEnoughEggs = true;
                    break;
                }
                else
                {
                    startingEggs -= eggs;
                }

                command = Console.ReadLine();
            }

            if (!notEnoughEggs)
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{eggsSold} eggs sold.");
            }
            else
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {startingEggs}.");
            }
        }
    }
}
