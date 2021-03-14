using System.Collections.Generic;
using System.Linq;
using WildFarm.Contracts;

namespace WildFarm.Models.Animals
{
    class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
            
        }

        protected override IReadOnlyCollection<string> EatenFoods => new List<string>() { };

        protected override double WeightAccelerator => 0.35;

        public override string AskForFood()
        {
            return $"Cluck";
        }
    }
}
