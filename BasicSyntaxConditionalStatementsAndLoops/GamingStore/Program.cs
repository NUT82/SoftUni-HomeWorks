using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            float currBalance = float.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();
            float allGamePrice = 0f;
            while (gameName != "Game Time")
            {
                float currGamePrice = 0f;
                switch (gameName)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        currGamePrice = 39.99f;
                        break;
                    case "CS: OG":
                        currGamePrice = 15.99f;
                        break;
                    case "Zplinter Zell":
                        currGamePrice = 19.99f;
                        break;
                    case "Honored 2":
                        currGamePrice = 59.99f;
                        break;
                    case "RoverWatch":
                        currGamePrice = 29.99f;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        gameName = Console.ReadLine();
                        continue;
                }
                if (currGamePrice > currBalance)
                {
                    Console.WriteLine("Too Expensive");
                    gameName = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine($"Bought {gameName}");
                    allGamePrice += currGamePrice;
                    currBalance -= currGamePrice;
                }
                if (currBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                else
                {
                    gameName = Console.ReadLine();
                }
            }
            Console.WriteLine($"Total spent: ${allGamePrice:F2}. Remaining: ${currBalance:F2}");
        }
    }
}
