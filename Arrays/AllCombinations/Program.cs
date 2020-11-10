using System;

namespace Food_for_Pets
{
    class StartUp
    {
        static int numberOfLoops = int.Parse(Console.ReadLine());
        static int numberOfIteration = int.Parse(Console.ReadLine());
        static int[] loops = new int[numberOfLoops];
        static void Main(string[] args)
        {
            for (int i = 1; i < numberOfLoops; i++)
            {
                numberOfLoops = i;
                NestedLoops();
            }
            
        }

        static void NestedLoops()
        {
            InitLoops();
            int currPosition = 0;
            while (true)
            {
                PrintLoop();
                currPosition = numberOfLoops - 1;
                loops[currPosition] = loops[currPosition] + 1;
                while (loops[currPosition] > numberOfIteration)
                {
                    loops[currPosition] = 1;
                    currPosition--;
                    if (currPosition < 0)
                    {
                        return;
                    }
                    loops[currPosition] = loops[currPosition] + 1;
                }
            }
        }

        static void InitLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                loops[i] = 1;
            }
        }

        static void PrintLoop()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write($"{loops[i]} ");
            }
            Console.WriteLine();
        }
    }
}
