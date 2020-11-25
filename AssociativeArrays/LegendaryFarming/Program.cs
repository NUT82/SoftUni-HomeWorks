using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> keyMaterials = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne" },
                { "fragments", "Valanyr" },
                { "motes", "Dragonwrath" }
            };
            string legendaryItem = "";
            SortedDictionary<string, int> items = new SortedDictionary<string, int>()
            {
                { "fragments", 0 },
                { "motes", 0 },
                { "shards", 0 }
            };
            while (legendaryItem == "")
            {
                string[] quantityAndMaterial = Console.ReadLine().Split();
                for (int i = 0; i < quantityAndMaterial.Length; i += 2)
                {
                    string currMaterial = quantityAndMaterial[i + 1].ToLower();
                    int currQuantity = int.Parse(quantityAndMaterial[i]);
                    if (items.ContainsKey(currMaterial))
                    {
                        items[currMaterial] += currQuantity;
                    }
                    else
                    {
                        items.Add(currMaterial, currQuantity);
                    }

                    if (keyMaterials.ContainsKey(currMaterial))
                    {
                        if (items[currMaterial] >= 250)
                        {
                            legendaryItem = keyMaterials[currMaterial];
                            items[currMaterial] -= 250;
                            break;
                        }
                    }
                }


            }

            Console.WriteLine($"{legendaryItem} obtained!");
            foreach (var item in items.Where(m => keyMaterials.ContainsKey(m.Key)).OrderByDescending(q => q.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in items.Where(m => keyMaterials.ContainsKey(m.Key) == false))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
