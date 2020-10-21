using System;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете число n, въведено от потребителя, и чертае квадрат от n * n звездички. Разликата с предходната задача е, че между всеки две звездички има по един интервал.
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int a = 0; a < N; a++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
