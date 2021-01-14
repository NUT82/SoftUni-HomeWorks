using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //I Love C#
            string text = Console.ReadLine();
            Stack<char> reversedChars = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
            {
                reversedChars.Push(text[i]);
            }

            while (reversedChars.Count > 0)
            {
                Console.Write(reversedChars.Pop());
            }

        }
    }
}
