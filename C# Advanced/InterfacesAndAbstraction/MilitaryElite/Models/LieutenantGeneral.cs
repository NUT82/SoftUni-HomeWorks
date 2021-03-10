using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            :base(id, firstName, lastName, salary)
        {
            Privates = new List<Private>();
        }

        public List<Private> Privates { get; protected set; }

        public void AddPrivate(Private privates)
        {
            Privates.Add(privates);
        }

        public override string ToString()
        {
            return ($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}" + Environment.NewLine +
                   $"Privates:" + Environment.NewLine + "  " +
                   string.Join(Environment.NewLine + "  ", Privates)).TrimEnd();
        }
    }
}
