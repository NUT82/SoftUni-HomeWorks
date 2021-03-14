using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models.Animals
{
    class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override IReadOnlyCollection<string> EatenFoods => new List<string>() { nameof(Vegetable), nameof(Meat) };

        protected override double WeightAccelerator => 0.30;

        public override string AskForFood()
        {
            return $"Meow";
        }
    }
}
