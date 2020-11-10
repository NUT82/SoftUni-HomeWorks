using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            PrintCountOfVowels(inputString);
        }

        private static void PrintCountOfVowels(string inputString)
        {
            const string vowels = "aouei";
            inputString = inputString.ToLower();
            int vowelCounter = 0;

            foreach (var item in inputString)
            {
                if (vowels.Contains(item))
                {
                    vowelCounter++;
                }
            }

            Console.WriteLine(vowelCounter);
        }
    }
}
