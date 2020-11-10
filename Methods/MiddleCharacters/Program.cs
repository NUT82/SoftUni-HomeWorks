using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            PrintMiddleChars(inputString);
        }

        private static void PrintMiddleChars(string inputString)
        {
            if (inputString.Length % 2 != 0)
            {
                Console.WriteLine(inputString[inputString.Length / 2]);
            }
            else
            {
                Console.WriteLine(inputString.Substring(inputString.Length / 2 - 1, 2));
            }
        }
    }
}
