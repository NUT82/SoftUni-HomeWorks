using System;

namespace GiftsFromSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int numberS = int.Parse(Console.ReadLine());

            for (int i = numberM; i >= numberN; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == numberS)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
