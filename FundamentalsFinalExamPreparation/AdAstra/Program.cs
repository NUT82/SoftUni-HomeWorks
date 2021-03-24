using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxCalories = 10000;
            const int neededCaloriesPerDay = 2000;

            string pattern = @"([#|])(?<food>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";

            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            List<Food> foods = new List<Food>();
            foreach (Match match in matches.Where(c => int.Parse(c.Groups["calories"].Value) <= maxCalories))
            {
                Food food = new Food(match.Groups["food"].Value, match.Groups["date"].Value, int.Parse(match.Groups["calories"].Value));
                foods.Add(food);
            }

            Console.WriteLine($"You have food to last you for: {foods.Sum(c => c.Calories) / neededCaloriesPerDay} days!");
            Console.WriteLine(string.Join(Environment.NewLine, foods));
        }

        public class Food
        {
            public Food(string name, string date, int calories)
            {
                Name = name;
                Date = date;
                Calories = calories;
            }

            public string Name { get; set; }

            public string Date { get; set; }

            public int Calories { get; set; }

            public override string ToString()
            {
                return $"Item: {Name}, Best before: {Date}, Nutrition: {Calories}";
            }
        }
    }
}
