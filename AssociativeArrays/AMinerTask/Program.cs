using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string line = Console.ReadLine();
            while (line != "stop")
            {
                string currResourse = line;
                int currQuantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(currResourse))
                {
                    resources[currResourse] += currQuantity;
                }
                else
                {
                    resources.Add(currResourse, currQuantity);
                }

                line = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
