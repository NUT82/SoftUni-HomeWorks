using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Models.Animals;

namespace WildFarm.Creators.Animals
{
    class MouseCreator : MammalCreator
    {
        public MouseCreator(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override Animal CreateAnimal()
        {
            return new Mouse(name, weight, livingRegion);
        }
    }
}
