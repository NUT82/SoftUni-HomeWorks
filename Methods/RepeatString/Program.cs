using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());


            Console.WriteLine(GetTextRepeatly(text, repeatCount));
        }

        static StringBuilder GetTextRepeatly(string text, int repeatCount)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < repeatCount; i++)
            {
                newString.Append(text);
            }
            return newString;
        }
    }
}
