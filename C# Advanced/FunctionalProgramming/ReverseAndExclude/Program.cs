using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int number = int.Parse(Console.ReadLine());

            Func<int, int, bool> filter = (n, number) => n % number != 0;

            int[] result = input.Where(n => filter(n, number)).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
