using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models.Animals
{
    class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override IReadOnlyCollection<string> EatenFoods => new List<string>() { nameof(Meat) };

        protected override double WeightAccelerator => 0.40;

        public override string AskForFood()
        {
            return $"Woof!";
        }
    }
}
