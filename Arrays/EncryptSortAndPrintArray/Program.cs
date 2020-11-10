using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
            //•	The code of each vowel multiplied by the string length
            //•	The code of each consonant divided by the string length
            //Sort the number sequence in ascending order and print it on the console.
            //On first line, you will always receive the number of strings you have to read
            const string allVowelLetters = "aoueiAOUEI";
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] encryptedStrings = new int[numberOfStrings];
            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    if (allVowelLetters.Contains(input[j]))
                    {
                        encryptedStrings[i] += (int)input[j] * input.Length;
                    }
                    else
                    {
                        encryptedStrings[i] += (int)input[j] / input.Length;
                    }
                }
            }
            Array.Sort(encryptedStrings);
            Console.WriteLine(string.Join(Environment.NewLine, encryptedStrings));
        }
    }
}
