using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 10; i >= 2; i--)
            {
                if (number % i == 0 && (i == 10 || i == 7 || i == 6 || i == 3 || i == 2))
                {
                    Console.WriteLine($"The number is divisible by {i}");
                    return;
                }
            }
            Console.WriteLine("Not divisible");
        }
    }
}
