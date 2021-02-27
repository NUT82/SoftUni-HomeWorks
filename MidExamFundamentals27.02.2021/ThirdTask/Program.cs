using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine().Split().Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItem = Console.ReadLine();

            int valueOfEntryPoint = priceRatings[entryPoint];
            List<int> leftList = priceRatings.Take(entryPoint).ToList();
            List<int> rightList = priceRatings.TakeLast(priceRatings.Count - 1 - entryPoint).ToList();
            int leftListInitialSum = leftList.Sum();
            int rightListInitialSum = rightList.Sum();

            if (typeOfItem == "cheap")
            {
                leftList.RemoveAll(x => x < valueOfEntryPoint);
                rightList.RemoveAll(x => x < valueOfEntryPoint);
            }
            else
            {
                leftList.RemoveAll(x => x >= valueOfEntryPoint);
                rightList.RemoveAll(x => x >= valueOfEntryPoint);
            }

            if (leftListInitialSum - leftList.Sum() >= rightListInitialSum - rightList.Sum())
            {
                Console.WriteLine($"Left - {leftListInitialSum - leftList.Sum()}");
            }
            else
            {
                Console.WriteLine($"Right - {rightListInitialSum - rightList.Sum()}");
            }
        }
    }
}
