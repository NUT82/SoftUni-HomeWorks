using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Enums.Corp corp)
            : base(id, firstName, lastName, salary)
        {
            Corp = corp;
        }

        public Enums.Corp Corp { get; private set; }
    }
}
