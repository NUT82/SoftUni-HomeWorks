using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> filter = (s, n) => s.Length <= n;

            Console.WriteLine(string.Join(Environment.NewLine, names.Where(s => filter(s, number))));
        }
    }
}
