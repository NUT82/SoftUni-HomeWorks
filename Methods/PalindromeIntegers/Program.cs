using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindromeInteger(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindromeInteger(string input)
        {
            int lengthOfString = input.Length - 1;
            for (int i = 0; i <= lengthOfString; i++, lengthOfString--)
            {
                if (input[i] != input[lengthOfString])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
