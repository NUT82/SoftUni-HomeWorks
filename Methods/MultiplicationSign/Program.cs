using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintMultiplicationSign(numberOne, numberTwo, numberThree));
        }

        private static string PrintMultiplicationSign(int numberOne, int numberTwo, int numberThree)
        {
            string result = "";
            int[] numbers = { numberOne, numberTwo, numberThree };

            if (CountZeroNumbers(numbers) > 0)
            {
                result = "zero";
            }
            else if (CountNegativeNumbers(numbers) % 2 == 0)
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }

            return result;
        }

        private static int CountZeroNumbers(int[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                if (item == 0)
                {
                    result++;
                }
            }

            return result;
        }

        private static int CountNegativeNumbers(int[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                if (item < 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}


