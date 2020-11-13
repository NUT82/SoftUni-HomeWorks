using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPointsOfBaker = 0;
            string bakerWithMaxPoint = "";

            int easterBreads = int.Parse(Console.ReadLine());

            for (int i = 0; i < easterBreads; i++)
            {
                string nameOfBaker = Console.ReadLine();
                int pointsForCurrBaker = 0;
                string input = Console.ReadLine();
                while (input != "Stop")
                {
                    int points = int.Parse(input);
                    pointsForCurrBaker += points;
                    input = Console.ReadLine();
                }

                Console.WriteLine($"{nameOfBaker} has {pointsForCurrBaker} points.");

                if (pointsForCurrBaker > maxPointsOfBaker)
                {
                    Console.WriteLine($"{nameOfBaker} is the new number 1!");
                    maxPointsOfBaker = pointsForCurrBaker;
                    bakerWithMaxPoint = nameOfBaker;
                }
            }

            Console.WriteLine($"{bakerWithMaxPoint} won competition with {maxPointsOfBaker} points!");
        }
    }
}
