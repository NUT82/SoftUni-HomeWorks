using System;
using System.Linq;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(new string(text.Where(c => char.IsDigit(c)).ToArray()));
            Console.WriteLine(new string(text.Where(c => char.IsLetter(c)).ToArray()));
            Console.WriteLine(new string(text.Where(c => !char.IsLetterOrDigit(c)).ToArray()));
        }
    }
}
