using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Models.Animals;

namespace WildFarm.Creators.Animals
{
    class OwlCreator : BirdCreator
    {
        public OwlCreator(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override Animal CreateAnimal()
        {
            return new Owl(name, weight, wingSize);
        }
    }
}
