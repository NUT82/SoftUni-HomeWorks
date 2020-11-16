using System;

namespace ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = 0;
            int kids = 0;
            int moneyForToys = 0;
            int moneyForSweaters = 0;

            string input = Console.ReadLine();

            while (input != "Christmas")
            {
                int ages = int.Parse(input);

                if (ages > 16)
                {
                    adults++;
                }
                else
                {
                    kids++;
                }

                input = Console.ReadLine();
            }

            moneyForToys = kids * 5;
            moneyForSweaters = adults * 15;

            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");
        }
    }
}
