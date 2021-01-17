using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[,] matrix = new char[number, number];

            for (int row = 0; row < number; row++)
            {
                string currRow = Console.ReadLine();
                for (int col = 0; col < number; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            string searchSymbol = Console.ReadLine();
            bool isFind = false;

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    if (matrix[row, col] == searchSymbol[0])
                    {
                        isFind = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
            }

            if (!isFind)
            {
                Console.WriteLine($"{searchSymbol[0]} does not occur in the matrix");
            }
        }
    }
}
