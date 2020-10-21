using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете число n (1 ≤ n ≤ 100), въведено от потребителя, и печата коледна елха с размер n като в примерите по-долу:
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int space = 0; space < n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < i; star++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int star = 0; star < i; star++)
                {
                    Console.Write("*");
                }
                for (int space = 0; space < n - i; space++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
