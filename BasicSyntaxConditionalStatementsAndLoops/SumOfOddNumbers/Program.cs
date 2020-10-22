using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOddNumbers = int.Parse(Console.ReadLine());
            int sumOddNumbers = 0;
            int currOddNumber = 1;

            while (countOddNumbers > 0)
            {
                sumOddNumbers += currOddNumber;
                Console.WriteLine(currOddNumber);
                currOddNumber += 2;
                countOddNumbers--;
            }
            Console.WriteLine("Sum: " + sumOddNumbers);
        }
    }
}
