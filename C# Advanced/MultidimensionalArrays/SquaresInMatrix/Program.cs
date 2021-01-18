using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currRow = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col][0];
                }
            }

            int equalSquares = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int count = 0;
                    for (int i = row; i < row + 2; i++)
                    {
                        for (int j = col; j < col + 2; j++)
                        {
                            if (matrix[row, col] == matrix[i, j])
                            {
                                count++;
                            }
                        }
                    }
                    if (count == 4)
                    {
                        equalSquares++;
                    }
                }
            }

            Console.WriteLine(equalSquares);
        }
    }
}
