using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a single integer. Your task is to find the sum of its digits.
            string numberAsString = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                sum += int.Parse(numberAsString[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
