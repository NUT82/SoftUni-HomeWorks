using System;
using System.Collections.Generic;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> ships = new List<char> { '<', '>' };
            int fieldSize = int.Parse(Console.ReadLine());

            int[] attackCoordinates = Console.ReadLine()
                                            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            char[,] field = new char[fieldSize, fieldSize];
            int[] playerShipsCount = new int[2];

            for (int row = 0; row < fieldSize; row++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(c => c[0]).ToArray();
                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = currentRow[col];
                    int playerShip = ships.IndexOf(field[row, col]);

                    if (playerShip != -1)
                    {
                        playerShipsCount[playerShip]++;
                    }
                }
            }

            int allPlayerShipsCount = playerShipsCount.Sum();
            bool gameDraw = true;

            for (int i = 0; i < attackCoordinates.Length; i += 2)
            {
                if (ValidCoordinates(attackCoordinates[i], attackCoordinates[i + 1], fieldSize))
                {
                    switch (field[attackCoordinates[i], attackCoordinates[i + 1]])
                    {
                        case '#':
                            BlowMine(attackCoordinates[i], attackCoordinates[i + 1], field, playerShipsCount);
                            break;
                        case '<':
                            field[attackCoordinates[i], attackCoordinates[i + 1]] = 'X';
                            playerShipsCount[0]--;
                            break;
                        case '>':
                            field[attackCoordinates[i], attackCoordinates[i + 1]] = 'X';
                            playerShipsCount[1]--;
                            break;
                    }
                }

                if (playerShipsCount.Contains(0))
                {
                    gameDraw = false;
                    break;
                }
            }

            if (gameDraw)
            {
                Console.WriteLine($"It's a draw! Player One has {playerShipsCount[0]} ships left. Player Two has {playerShipsCount[1]} ships left.");
            }
            else if (playerShipsCount[1] == 0)
            {
                Console.WriteLine($"Player One has won the game! {allPlayerShipsCount - playerShipsCount[0]} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"Player Two has won the game! {allPlayerShipsCount - playerShipsCount[1]} ships have been sunk in the battle.");
            }
        }

        private static void BlowMine(int x, int y, char[,] field, int[] playerShipsCount)
        {
            field[x, y] = 'X';
            for (int row = x - 1; row <= x + 1; row++)
            {
                for (int col = y - 1; col <= y + 1; col++)
                {
                    if (ValidCoordinates(row, col, field.GetLength(0)))
                    {
                        if (field[row, col] == '<')
                        {
                            playerShipsCount[0]--;
                            field[row, col] = 'X';
                        }
                        else if (field[row, col] == '>')
                        {
                            playerShipsCount[1]--;
                            field[row, col] = 'X';
                        }
                    }
                }
            }
        }

        public static bool ValidCoordinates(int x, int y, int fieldSize)
        {
            return (x < fieldSize && y < fieldSize && x >= 0 && y >= 0);
        }
    }
}
