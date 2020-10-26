using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).
            int numberN = int.Parse(Console.ReadLine());
            bool isSpecialNumber = false; //A number is special when its sum of digits is 5, 7 or 11.
            for (int i = 1; i <= numberN; i++)
            {
                int sumOfDigits = 0;
                int currNumer = i;
                while (currNumer > 0)
                {
                    sumOfDigits += currNumer % 10;
                    currNumer /= 10;
                }
                isSpecialNumber = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                if (isSpecialNumber)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }

        }
    }
}
