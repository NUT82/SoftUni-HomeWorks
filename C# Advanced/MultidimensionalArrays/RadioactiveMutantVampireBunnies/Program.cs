using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];

            char[,] lair = new char[rows, cols];

            int[] playerCoordinates = new int[] { 0, 0 };
            for (int row = 0; row < rows; row++)
            {
                string currRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    lair[row, col] = currRow[col];
                    if (lair[row, col] == 'P')
                    {
                        playerCoordinates[0] = row;
                        playerCoordinates[1] = col;
                    }
                }
            }

            Queue<char> directions = new Queue<char>(Console.ReadLine().ToCharArray());
            bool winGame = false;
            bool loseGame = false;

            while (directions.Count > 0 && !winGame && !loseGame)
            {
                //move player
                int moveRow = 0;
                int moveCol = 0;

                switch (directions.Dequeue())
                {
                    case 'L':
                        moveCol--;
                        break;
                    case 'R':
                        moveCol++;
                        break;
                    case 'U':
                        moveRow--;
                        break;
                    case 'D':
                        moveRow++;
                        break;
                    default:
                        break;
                }

                lair[playerCoordinates[0], playerCoordinates[1]] = '.';
                if (IsValidCoordinates(playerCoordinates[0] + moveRow, playerCoordinates[1] + moveCol, lair))
                {
                    playerCoordinates[0] += moveRow;
                    playerCoordinates[1] += moveCol;
                    if (lair[playerCoordinates[0], playerCoordinates[1]] == '.')
                    {
                        lair[playerCoordinates[0], playerCoordinates[1]] = 'P';
                    }
                    else
                    {
                        loseGame = true;
                    }
                }
                else
                {
                    winGame = true;
                }

                //spread Bunnies
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (lair[row, col] == 'B')
                        {
                            if (IsValidCoordinates(row - 1, col, lair) && lair[row - 1, col] != 'B')
                            {
                                if (lair[row - 1, col] == 'P')
                                {
                                    loseGame = true;
                                }
                                lair[row - 1, col] = 'b';
                            }

                            if (IsValidCoordinates(row + 1, col, lair) && lair[row + 1, col] != 'B')
                            {
                                if (lair[row + 1, col] == 'P')
                                {
                                    loseGame = true;
                                }
                                lair[row + 1, col] = 'b';
                            }

                            if (IsValidCoordinates(row, col - 1, lair) && lair[row, col - 1] != 'B')
                            {
                                if (lair[row, col - 1] == 'P')
                                {
                                    loseGame = true;
                                }
                                lair[row, col - 1] = 'b';
                            }

                            if (IsValidCoordinates(row, col + 1, lair) && lair[row, col + 1] != 'B')
                            {
                                if (lair[row, col + 1] == 'P')
                                {
                                    loseGame = true;
                                }
                                lair[row, col + 1] = 'b';
                            }
                        }
                    }
                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (lair[row, col] == 'b')
                        {
                            lair[row, col] = 'B';
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }

            if (winGame)
            {
                Console.Write("won: ");
            }
            else if (loseGame)
            {
                Console.Write("dead: ");
            }
            Console.WriteLine(string.Join(" ", playerCoordinates));

        }

        private static bool IsValidCoordinates(int row, int col, char[,] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
    }
}
