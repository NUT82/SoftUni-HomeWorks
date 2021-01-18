using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowsAndCols, rowsAndCols];

            for (int row = 0; row < rowsAndCols; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowsAndCols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;
            for (int i = 0; i < rowsAndCols; i++)
            {
                sumFirstDiagonal += matrix[i, i];
                sumSecondDiagonal += matrix[rowsAndCols - i - 1, i];
            }

            Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
        }
    }
}
