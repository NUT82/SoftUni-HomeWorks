using System;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that returns the English name of the last digit of a given number. Write a program that reads an integer and prints the returned value from this method.
            int inputNumber = int.Parse(Console.ReadLine());
            int lastDigit = inputNumber % 10;
            string[] stringDigits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            Console.WriteLine(stringDigits[lastDigit]);
        }
    }
}
