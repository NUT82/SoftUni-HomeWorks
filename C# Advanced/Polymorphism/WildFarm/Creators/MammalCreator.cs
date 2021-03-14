using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Creators
{
    abstract class MammalCreator : AnimalCreator
    {
        protected string livingRegion;
        protected MammalCreator(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.livingRegion = livingRegion;
        }
    }
}
