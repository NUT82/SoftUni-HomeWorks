using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class PaladinCreator : BaseHeroCreator
    {
        private readonly string name;

        public PaladinCreator(string name)
        {
            this.name = name;
        }

        public override BaseHero GetBaseHero()
        {
            return new Paladin(name);
        }
    }
}
