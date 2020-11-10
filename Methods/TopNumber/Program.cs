using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                if (IsDevisibleByEight(i) && HaveAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }

            }

        }

        private static bool HaveAtLeastOneOddDigit(int number)
        {
            while (number > 0)
            {
                int currDigit = number % 10;
                if (currDigit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static bool IsDevisibleByEight(int number)
        {
            return GetSumOfDigits(number) % 8 == 0;
        }

        static int GetSumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currDigit = number % 10;
                sum += currDigit;
                number /= 10;
            }

            return sum;
        }
    }
}
