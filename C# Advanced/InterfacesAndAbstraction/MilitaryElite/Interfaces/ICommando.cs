using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ICommando : ISpecialisedSoldier
    {
        Dictionary<string, Mission> Missions { get; }

        public void AddMission(Mission missions);

        public void CompleteMission(string codeName);
    }
}
