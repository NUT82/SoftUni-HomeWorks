using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Creators
{
    abstract class BirdCreator : AnimalCreator
    {
        protected double wingSize;
        protected BirdCreator(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.wingSize = wingSize;
        }
    }
}
