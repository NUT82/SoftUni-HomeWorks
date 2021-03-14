using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Creators;
using WildFarm.Models;

namespace WildFarm.Contracts
{
    abstract class Animal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        protected abstract IReadOnlyCollection<string> EatenFoods { get; }

        protected abstract double WeightAccelerator { get; }

        public abstract string AskForFood();

        public void Feed(Food food)
        {
            if (!EatenFoods.Contains(food.GetType().Name) && EatenFoods.Count != 0)
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightAccelerator;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
    }
}
