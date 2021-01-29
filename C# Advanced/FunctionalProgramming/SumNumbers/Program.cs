using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> func = ReturnSumAndCountInArray;
            Console.WriteLine(string.Join(Environment.NewLine, func(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
                )));

            //Action<int[]> Printer = PrintSumAndCount;
            //Printer(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
        }

        private static void PrintSumAndCount(int[] obj)
        {
            Console.WriteLine(obj.Length);
            Console.WriteLine(obj.Sum());
        }

        public static int[] ReturnSumAndCountInArray(int[] array)
        {
            int[] result = new int[2];
            result[0] = array.Length;
            result[1] = array.Sum();
            return result;
        }
    }
}
