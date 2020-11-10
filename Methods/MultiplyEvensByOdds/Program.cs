using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(number), GetSumOfOddDigits(number)));
        }

        static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            return even * odd;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            
            while (number > 0)
            {
                int currDigit = number % 10;
                if (currDigit % 2 == 0)
                {
                    sum += currDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            
            while (number > 0)
            {
                int currDigit = number % 10;
                if (currDigit % 2 != 0)
                {
                    sum += currDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
