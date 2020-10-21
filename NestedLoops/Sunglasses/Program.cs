using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло число n (3 ≤ n ≤ 100), въведено от потребителя, и печата слънчеви очила с размер 5*n x n като в примерите:
            //3
            //******   ******
            //*////*|||*////*
            //******   ******

            int n = int.Parse(Console.ReadLine());
            double center = Math.Ceiling(n / 2.00);
            for (int rows = 1; rows <= n; rows++)
            {
                if (rows == 1 || rows == n)
                {
                    for (int star = 1; star <= (5 * n - n) / 2; star++)
                    {
                        Console.Write("*");
                    }
                    for (int space = 1; space <= n; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int star = 1; star <= (5 * n - n) / 2; star++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int slash = 1; slash <= (5 * n - n) / 2 - 2; slash++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    for (int spaceOrSlash = 1; spaceOrSlash <= n; spaceOrSlash++)
                    {
                        if (rows != center)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("|");
                        }
                    }
                    Console.Write("*");
                    for (int slash = 1; slash <= (5 * n - n) / 2 - 2; slash++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
