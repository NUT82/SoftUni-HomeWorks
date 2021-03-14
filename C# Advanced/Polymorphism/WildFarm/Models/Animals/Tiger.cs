using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models.Animals
{
    class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override IReadOnlyCollection<string> EatenFoods => new List<string>() { nameof(Meat) };

        protected override double WeightAccelerator => 1.00;

        public override string AskForFood()
        {
            return $"ROAR!!!";
        }
    }
}
