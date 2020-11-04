using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically:
            int numberOfLetters = int.Parse(Console.ReadLine());
            for (int i = 97; i < 97 + numberOfLetters; i++)
            {
                for (int j = 97; j < 97 + numberOfLetters; j++)
                {
                    for (int k = 97; k < 97 + numberOfLetters; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
