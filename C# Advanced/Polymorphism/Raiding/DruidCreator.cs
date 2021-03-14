using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class DruidCreator : BaseHeroCreator
    {
        private readonly string name;

        public DruidCreator(string name)
        {
            this.name = name;
        }

        public override BaseHero GetBaseHero()
        {
            return new Druid(name);
        }
    }
}
