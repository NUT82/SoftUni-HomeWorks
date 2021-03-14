using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Creators
{
    abstract class FelineCreator : MammalCreator
    {
        protected string breed;
        protected FelineCreator(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.breed = breed;
        }
    }
}
