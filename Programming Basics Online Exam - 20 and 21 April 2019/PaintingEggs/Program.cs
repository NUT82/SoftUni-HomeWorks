using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColor = Console.ReadLine();
            int numberOfLots = int.Parse(Console.ReadLine());

            double productionCosts = 0.35;
            double finalPrice = 0;

            switch (eggsSize)
            {
                case "Large":
                    finalPrice = numberOfLots * 16;
                    if (eggsColor == "Green")
                    {
                        finalPrice = numberOfLots * 12;
                    }
                    else if (eggsColor == "Yellow")
                    {
                        finalPrice = numberOfLots * 9;
                    }
                    break;
                case "Medium":
                    finalPrice = numberOfLots * 13;
                    if (eggsColor == "Green")
                    {
                        finalPrice = numberOfLots * 9;
                    }
                    else if (eggsColor == "Yellow")
                    {
                        finalPrice = numberOfLots * 7;
                    }
                    break;
                case "Small":
                    finalPrice = numberOfLots * 9;
                    if (eggsColor == "Green")
                    {
                        finalPrice = numberOfLots * 8;
                    }
                    else if (eggsColor == "Yellow")
                    {
                        finalPrice = numberOfLots * 5;
                    }
                    break;
                default:
                    break;
            }

            finalPrice -= finalPrice * productionCosts;

            Console.WriteLine($"{finalPrice:F2} leva.");
        }
    }
}
