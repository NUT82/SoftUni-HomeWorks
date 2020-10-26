using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 lines of input. On each line you get a single character. Combine all the characters into one string and print it on the console.
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());
            string output = char1.ToString() + char2.ToString() + char3.ToString();
            Console.WriteLine(output);
        }
    }
}
