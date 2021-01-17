using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputRowsCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = inputRowsCols[0];
            int cols = inputRowsCols[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
                sum += currRow.Sum();
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
