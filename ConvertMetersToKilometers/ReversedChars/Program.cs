using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes 3 lines of characters and prints them in reversed order with a space between them.
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{char3} {char2} {char1}");
        }
    }
}
