using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0. For example, the initial number in the first (or any other) row is 1 (the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.
            //If you want more info about it: https://en.wikipedia.org/wiki/Pascal's_triangle
            //Print each row elements separated with whitespace.

            int number = int.Parse(Console.ReadLine());
            int[,] outputArray = new int[number,number];
            outputArray[0, 0] = 1;
            Console.WriteLine("1");
            for (int i = 1; i < number; i++)
            {
                outputArray[i, 0] = outputArray[i, i] = 1;
                for (int j = 1; j < i; j++)
                {
                    outputArray[i, j] = outputArray[i - 1, j - 1] + outputArray[i - 1, j];
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write($"{outputArray[i,k]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
