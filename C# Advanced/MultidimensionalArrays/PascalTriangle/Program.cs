using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[rows][];
            pascalTriangle[0] = new long[1] { 1 };
            for (int row = 1; row < rows; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    long value = 0;
                    if (isValidCoordinates(row - 1, col - 1, pascalTriangle))
                    {
                        value += pascalTriangle[row - 1][col - 1];
                    }
                    if (isValidCoordinates(row - 1, col, pascalTriangle))
                    {
                        value += pascalTriangle[row - 1][col];
                    }
                    pascalTriangle[row][col] = value;
                }
            }

            foreach (var currRow in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", currRow));
            }
        }

        private static bool isValidCoordinates(int row, int col, long[][] pascalTriangle)
        {
            return (col >= 0 && col < pascalTriangle[row].Length);
        }
    }
}
