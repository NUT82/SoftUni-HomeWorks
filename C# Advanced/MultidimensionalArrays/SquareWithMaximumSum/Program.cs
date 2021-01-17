using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputRowsCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = inputRowsCols[0];
            int cols = inputRowsCols[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int sumCurrSquare = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sumCurrSquare > maxSum)
                    {
                        maxSum = sumCurrSquare;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]}");
            Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
