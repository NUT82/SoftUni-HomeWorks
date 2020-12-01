using System;
using System.Diagnostics;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string[] line = Console.ReadLine().Split();
            string result = "";
            foreach (var word in line)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result + "-" + stopwatch.ElapsedMilliseconds);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in line)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    stringBuilder.Append(item);
                }
            }

            Console.WriteLine(stringBuilder + "-" + stopwatch.ElapsedMilliseconds);
        }
    }
}
