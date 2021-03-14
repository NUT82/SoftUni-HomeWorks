using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class RogueCreator : BaseHeroCreator
    {
        private readonly string name;

        public RogueCreator(string name)
        {
            this.name = name;
        }

        public override BaseHero GetBaseHero()
        {
            return new Rogue(name);
        }
    }
}
