using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override IReadOnlyCollection<string> EatenFoods => new List<string>() { nameof(Vegetable), nameof(Fruit)};

        protected override double WeightAccelerator => 0.10;

        public override string AskForFood()
        {
            return $"Squeak";
        }
    }
}
