using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] line = Console.ReadLine().Split("<->");
                string plantName = line[0];
                int rarity = int.Parse(line[1]);

                if (plants.Any(p => p.PlantName == plantName))
                {
                    plants.First(p => p.PlantName == plantName).Rarity = rarity;
                    continue;
                }

                plants.Add(new Plant(plantName, rarity));
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] splitCommand = command.Split(new char[] { ' ', '-', ':' }, StringSplitOptions.RemoveEmptyEntries);
                string currCommand = splitCommand[0];
                string currPlant = splitCommand[1];

                Plant plant = plants.FirstOrDefault(p => p.PlantName == currPlant);
                if (plant == null)
                {
                    currCommand = "error";
                }

                switch (currCommand)
                {
                    case "Rate":
                        int rating = int.Parse(splitCommand[2]);
                        plant.Rate(rating);
                        break;
                    case "Update":
                        int newRarirty = int.Parse(splitCommand[2]);
                        plant.Update(newRarirty);
                        break;
                    case "Reset":
                        plant.Reset();
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants.OrderByDescending(r => r.Rarity).ThenByDescending(ar => ar.AverageRating()))
            {
                Console.WriteLine($"- {plant.PlantName}; Rarity: {plant.Rarity}; Rating: {plant.AverageRating():F2}");
            }
        }

        public class Plant
        {
            public Plant(string name, int rarity)
            {
                PlantName = name;
                Rarity = rarity;
                Ratings = new List<int>();
            }

            public string PlantName { get; set; }

            public int Rarity { get; set; }

            public List<int> Ratings { get; set; }

            public void Rate(int rating)
            {
                Ratings.Add(rating);
            }

            public void Update(int newRarity)
            {
                Rarity = newRarity;
            }

            public void Reset()
            {
                Ratings.Clear();
            }

            public double AverageRating()
            {
                if (Ratings.Count == 0)
                {
                    return 0;
                }

                return Ratings.Average();
            }
        }
    }
}
