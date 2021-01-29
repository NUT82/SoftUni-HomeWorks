using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> IsUppercase = word => char.IsUpper(word[0]);
            var words = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Where(IsUppercase)
                        .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
