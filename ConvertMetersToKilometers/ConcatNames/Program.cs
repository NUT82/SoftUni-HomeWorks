using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two names and a delimiter. Print the names joined by the delimiter.
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{name1}{delimiter}{name2}");
        }
    }
}
