using System;

namespace RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло положително число n, въведено от потребителя, и печата на конзолата правоъгълник от n * n звездички.
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int a = 0; a < N; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
