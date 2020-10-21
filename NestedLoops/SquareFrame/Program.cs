using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло положително число n, въведено от потребителя, и чертае на конзолата квадратна рамка с размер n * n като в примерите по-долу:
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int a = 1; a <= n; a++)
                {
                    if (i == 1 || i == n)
                    {
                        if (a == 1 || a == n)
                        {
                            Console.Write("+ ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    else
                    {
                        if (a == 1 || a == n)
                        {
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
