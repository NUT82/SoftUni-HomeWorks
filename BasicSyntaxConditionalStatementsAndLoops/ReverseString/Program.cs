using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which reverses a string and print it on the console.
            string textString = Console.ReadLine();
            string reverseString = "";
            for (int i = textString.Length - 1; i >= 0; i--)
            {
                reverseString += textString[i];
            }
            Console.WriteLine(reverseString);
        }
    }
}
