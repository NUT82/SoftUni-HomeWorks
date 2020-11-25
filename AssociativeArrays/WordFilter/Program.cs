using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            foreach (var item in words.Where(x => x.Length % 2 == 0))
            {
                Console.WriteLine(item);
            }
        }
    }
}
