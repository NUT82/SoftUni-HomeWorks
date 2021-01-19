using System;
using System.Collections.Generic;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            char[,] field = new char[fieldSize, fieldSize];

            Queue<string> commands = new Queue<string>(Console.ReadLine().Split());

            int[] minerCoordinates = new int[] { 0, 0 };
            int allCoals = 0;

            for (int row = 0; row < fieldSize; row++)
            {
                string currRow = Console.ReadLine();
                currRow = currRow.Replace(" ", "");
                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = currRow[col];
                    if (field[row, col] == 's')
                    {
                        minerCoordinates[0] = row;
                        minerCoordinates[1] = col;
                    }

                    if (field[row, col] == 'c')
                    {
                        allCoals++;
                    }
                }
            }

            bool gameOver = false;
            int findCoal = 0;
            while (commands.Count > 0 && findCoal < allCoals)
            {
                int moveRow = 0;
                int moveCol = 0;

                switch (commands.Dequeue())
                {
                    case "left":
                        moveCol--;
                        break;
                    case "right":
                        moveCol++;
                        break;
                    case "up":
                        moveRow--;
                        break;
                    case "down":
                        moveRow++;
                        break;
                    default:
                        break;
                }

                if (IsValidCoordinates(minerCoordinates[0] + moveRow, minerCoordinates[1] + moveCol, field))
                {
                    minerCoordinates[0] += moveRow;
                    minerCoordinates[1] += moveCol;
                    if (field[minerCoordinates[0], minerCoordinates[1]] == 'c')
                    {
                        findCoal++;
                        field[minerCoordinates[0], minerCoordinates[1]] = '*';
                    }
                    else if (field[minerCoordinates[0], minerCoordinates[1]] == 'e')
                    {
                        gameOver = true;
                        break;
                    }
                }
            }

            if (gameOver)
            {
                Console.WriteLine($"Game over! ({minerCoordinates[0]}, {minerCoordinates[1]})");
            }
            else if (findCoal == allCoals)
            {
                Console.WriteLine($"You collected all coals! ({minerCoordinates[0]}, {minerCoordinates[1]})");
            }
            else
            {
                Console.WriteLine($"{allCoals - findCoal} coals left. ({minerCoordinates[0]}, {minerCoordinates[1]})");
            }
        }

        private static bool IsValidCoordinates(int row, int col, char[,] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
    }
}
