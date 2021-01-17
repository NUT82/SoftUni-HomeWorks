using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[,] matrix = new int[number, number];

            for (int row = 0; row < number; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < number; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
