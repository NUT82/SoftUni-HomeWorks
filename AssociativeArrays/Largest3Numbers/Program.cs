using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

            for (int i = 0; i < (numbers.Length > 3 ? 3 : numbers.Length); i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
