using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Models.Animals;

namespace WildFarm.Creators.Animals
{
    class CatCreator : FelineCreator
    {
        public CatCreator(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override Animal CreateAnimal()
        {
            return new Cat(name, weight, livingRegion, breed);
        }
    }
}
