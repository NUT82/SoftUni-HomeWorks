using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string firstString = line.Split()[0];
            string secondString = line.Split()[1];
            int sum = sumMultipliedCharacterCodes(firstString, secondString);
            Console.WriteLine(sum);
        }

        private static int sumMultipliedCharacterCodes(string firstString, string secondString)
        {
            int result = 0;
            for (int i = 0; i < Math.Max(firstString.Length, secondString.Length); i++)
            {
                int first = 1;
                if (i < firstString.Length)
                {
                    first = firstString[i];
                }
                int second = 1;
                if (i < secondString.Length)
                {
                    second = secondString[i];
                }
                result += first * second;
            }

            return result;
        }
    }
}
