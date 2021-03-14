using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Models.Animals;

namespace WildFarm.Creators.Animals
{
    class HenCreator : BirdCreator
    {
        public HenCreator(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override Animal CreateAnimal()
        {
            return new Hen(name, weight, wingSize);
        }
    }
}
