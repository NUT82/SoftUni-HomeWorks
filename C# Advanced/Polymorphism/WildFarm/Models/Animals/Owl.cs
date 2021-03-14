using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models.Animals
{
    class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override IReadOnlyCollection<string> EatenFoods => new List<string>() { "Meat" };

        protected override double WeightAccelerator => 0.25;

        public override string AskForFood()
        {
            return $"Hoot Hoot";
        }
    }
}
