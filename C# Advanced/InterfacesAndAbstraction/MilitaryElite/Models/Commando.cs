using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, Enums.Corp corp)
            : base(id, firstName, lastName, salary, corp)
        {
            Missions = new Dictionary<string, Mission>();
        }

        public Dictionary<string, Mission> Missions { get; set; }

        public void AddMission(Mission missions)
        {
            Missions.Add(missions.CodeName, missions);
        }

        public void CompleteMission(string codeName)
        {
            Missions[codeName].State = Enums.State.Finished;
        }

        public override string ToString()
        {
            return ($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}" + Environment.NewLine +
                   $"Corps: {Corp}" + Environment.NewLine +
                   $"Missions:" + Environment.NewLine +
                   string.Join(Environment.NewLine, Missions.Values)).TrimEnd();
        }
    }
}
