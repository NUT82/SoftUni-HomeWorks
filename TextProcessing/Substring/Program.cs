using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string forRemove = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(forRemove, StringComparison.OrdinalIgnoreCase);
            while (index != -1)
            {
                text = text.Remove(index, forRemove.Length);

                index = text.IndexOf(forRemove, StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine(text);
        }
    }
}
