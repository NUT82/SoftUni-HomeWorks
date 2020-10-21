using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло положително число n, въведено от потребителя, и печата ромбче от звездички с размер n като в примерите по-долу:
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n * 2; i++)
            {
                int interval = -(n - i);
                for (int c = 0; c < Math.Abs(interval); c++)
                {
                    Console.Write(" ");
                }
                for (int d = 0; d < n - Math.Abs(interval); d++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
