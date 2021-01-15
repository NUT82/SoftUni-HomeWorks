using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] capacityOfCups = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 1 5 28 1 4
            int[] waterInBottles = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 3 18 1 9 30 4 5
            Queue<int> cups = new Queue<int>(capacityOfCups);
            Stack<int> bottles = new Stack<int>(waterInBottles);
            int wastedLittersOfWater = 0;
            int deficit = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int water = bottles.Pop();
                if (water >= cups.Peek() + deficit)
                {
                    wastedLittersOfWater += water - cups.Dequeue() - deficit;
                    deficit = 0;
                }
                else
                {
                    deficit -= water; 
                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine("Cups: " + string.Join(" ", cups));
            }
            else
            {
                Console.WriteLine("Bottles: " + string.Join(" ", bottles));
            }
            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
        }
    }
}
