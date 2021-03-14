using System.Collections.Generic;
using WildFarm.Contracts;

namespace WildFarm.Creators
{
    abstract class AnimalCreator
    {
        protected readonly string name;
        protected readonly double weight;
        protected List<string> eatenFoods;

        public AnimalCreator(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
            eatenFoods = new List<string>();
        }

        public abstract Animal CreateAnimal();
    }
}
