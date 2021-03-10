using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public partial class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, Enums.Corp corp)
            : base(id, firstName, lastName, salary, corp)
        {
            Repairs = new List<Repair>();
        }

        public List<Repair> Repairs { get; private set; }

        public void AddRepair(Repair repairs)
        {
            Repairs.Add(repairs);
        }

        public override string ToString()
        {
            return ($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}" + Environment.NewLine +
                   $"Corps: {Corp}" + Environment.NewLine +
                   $"Repairs:" + Environment.NewLine +
                   string.Join(Environment.NewLine, Repairs)).TrimEnd();
        }
    }
}
