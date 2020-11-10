using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char lastChar = char.Parse(Console.ReadLine());

            PrintAllCharactersInRange(firstChar, lastChar);
        }

        private static void PrintAllCharactersInRange(char firstChar, char lastChar)
        {
            if (firstChar > lastChar)
            {
                for (int i = lastChar + 1; i < firstChar; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = firstChar + 1; i < lastChar; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            
        }
    }
}
