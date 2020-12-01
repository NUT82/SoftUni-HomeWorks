using System;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "end")
            {
                string reverse = new string(text.Reverse().ToArray());
                text += " = " + reverse;
                Console.WriteLine(text);

                text = Console.ReadLine();
            }
        }
    }
}
