using System;
using System.Numerics;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive number which represent how many lines we will get as an input. On the next N lines, you will receive a string with 2 numbers separated by single space. You need to compare them. If the left number is greater than the right number, you need to print the sum of all digits in the left number, otherwise print the sum of all digits in the right number.

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                int sumDigits = 0;
                string currLine = Console.ReadLine();
                string[] splitString = currLine.Split();
                int index = 1;
                if (BigInteger.Parse(splitString[0]) > BigInteger.Parse(splitString[1]))
                {
                    index = 0;
                }
                for (int j = 0; j < splitString[index].Length; j++)
                {
                    if (splitString[index][j] != '-')
                    {
                        sumDigits += int.Parse(splitString[index][j].ToString());
                    }
                }
                Console.WriteLine(sumDigits);
            }
        }
    }
}
