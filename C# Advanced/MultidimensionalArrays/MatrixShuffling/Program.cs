using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splitedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                bool isValidCommand =  splitedCommand.Length == 5 &&
                                       splitedCommand[0] == "swap" &&
                                       isValidCoordinates(int.Parse(splitedCommand[1]), int.Parse(splitedCommand[2]), matrix) &&
                                       isValidCoordinates(int.Parse(splitedCommand[3]), int.Parse(splitedCommand[4]), matrix);
                if (isValidCommand)
                {
                    string temp = matrix[int.Parse(splitedCommand[1]), int.Parse(splitedCommand[2])];
                    matrix[int.Parse(splitedCommand[1]), int.Parse(splitedCommand[2])] = matrix[int.Parse(splitedCommand[3]), int.Parse(splitedCommand[4])];
                    matrix[int.Parse(splitedCommand[3]), int.Parse(splitedCommand[4])] = temp;

                    printMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }


        }

        private static void printMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool isValidCoordinates(int row, int col, string[,] matrix)
        {
            return  row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
    }
}
