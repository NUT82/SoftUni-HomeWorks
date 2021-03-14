using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Models.Animals;

namespace WildFarm.Creators.Animals
{
    class TigerCreator : FelineCreator
    {
        public TigerCreator(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override Animal CreateAnimal()
        {
            return new Tiger(name, weight, livingRegion, breed);
        }
    }
}
