using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = SumDigits(numbers[i]);
                int lastPosibleIndex = text.Length - 1;
                while (sum > lastPosibleIndex)
                {
                    sum -= text.Length;
                }
                output.Append(text[sum]);
                text = text.Substring(0, sum) + text.Substring(sum + 1);
            }

            Console.WriteLine(output);
        }

        private static int SumDigits(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int currDigit = number % 10;
                result += currDigit;
                number /= 10;
            }
            return result;
        }
    }
}
