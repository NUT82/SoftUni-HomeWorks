using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints whether a given character is upper-case or lower case.
            char character = char.Parse(Console.ReadLine());
            if (character.ToString() == character.ToString().ToUpper())
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
