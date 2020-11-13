using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            int usedSugar = 0;
            int usedFlour = 0;
            int maxUsedSugar = 0;
            int maxUsedFlour = 0;

            for (int i = 0; i < easterBreads; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                if (sugar > maxUsedSugar)
                {
                    maxUsedSugar = sugar;
                }

                if (flour > maxUsedFlour)
                {
                    maxUsedFlour = flour;
                }

                usedSugar += sugar;
                usedFlour += flour;
            }

            Console.WriteLine($"Sugar: {(int)Math.Ceiling(usedSugar / 950.00)}");
            Console.WriteLine($"Flour: {(int)Math.Ceiling(usedFlour / 750.00)}");
            Console.WriteLine($"Max used flour is {maxUsedFlour} grams, max used sugar is {maxUsedSugar} grams.");
        }
    }
}
