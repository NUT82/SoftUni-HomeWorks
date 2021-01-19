using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] bombsMatrix = new int[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    bombsMatrix[row, col] = currRow[col];
                }
            }

            int[] bombs = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < bombs.Length; i += 2)
            {
                int bombRow = bombs[i];
                int bombCol = bombs[i + 1];
                int damage = bombsMatrix[bombRow, bombCol];
                if (damage > 0)
                {
                    for (int row = bombRow - 1; row < bombRow + 2; row++)
                    {
                        for (int col = bombCol - 1; col < bombCol + 2; col++)
                        {
                            if (IsValidCoordinates(row, col, bombsMatrix) && bombsMatrix[row, col] > 0)
                            {
                                bombsMatrix[row, col] -= damage;
                            }
                        }
                    }
                }
            }

            int sum = 0;
            int count = 0;
            foreach (var item in bombsMatrix)
            {
                if (item > 0)
                {
                    count++;
                    sum += item;
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    Console.Write(bombsMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValidCoordinates(int row, int col, int[,] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
    }
}
