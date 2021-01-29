using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Comparison<int> comparison = (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                return x.CompareTo(y);
            };
            Array.Sort(input, comparison);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
