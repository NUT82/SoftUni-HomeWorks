using System;

namespace TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете число n, въведено от потребителя, и печата триъгълник от долари като в примерите:
            int N = int.Parse(Console.ReadLine());
            int columns = 1;
            for (int i = 0; i < N; i++)
            {
                for (int a = 0; a < columns; a++)
                {
                    Console.Write("$ ");
                }
                columns++;
                Console.WriteLine();
            }
        }
    }
}
