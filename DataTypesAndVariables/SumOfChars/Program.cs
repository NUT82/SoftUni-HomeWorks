using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which sums the ASCII codes of n characters and prints the sum on the console.
            int countOfChars = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < countOfChars; i++)
            {
                char currChar = Console.ReadLine().ToCharArray()[0];
                sum += currChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
