using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class WarriorCreator : BaseHeroCreator
    {
        private readonly string name;

        public WarriorCreator(string name)
        {
            this.name = name;
        }

        public override BaseHero GetBaseHero()
        {
            return new Warrior(name);
        }
    }
}
