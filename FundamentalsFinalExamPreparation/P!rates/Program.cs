using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
            AddCities(cities);

            string text = Console.ReadLine();
            while (text != "End")
            {
                string[] tokens = text.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string city = tokens[1];
                if (command == "Plunder")
                {
                    int population = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);
                    cities[city].Population -= population;
                    cities[city].Gold -= gold;
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {population} citizens killed.");

                    if (cities[city].Population == 0 || cities[city].Gold == 0)
                    {
                        cities.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }
                }
                else
                {
                    int gold = int.Parse(tokens[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[city].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities[city].Gold} gold.");
                    }
                }

                text = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities.OrderByDescending(g => g.Value.Gold).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
        }

        private static void AddCities(Dictionary<string, City> cities)
        {
            string text = Console.ReadLine();
            while (text != "Sail")
            {
                string[] tokens = text.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string city = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new City(city, population, gold));
                }
                else
                {
                    cities[city].Population += population;
                    cities[city].Gold += gold;
                }

                text = Console.ReadLine();
            }
        }

        public class City
        {
            public City(string name, int population, int gold)
            {
                Name = name;
                Population = population;
                Gold = gold;
            }

            public string Name { get; set; }

            public int Population { get; set; }

            public int Gold { get; set; }
        }
    }
}
