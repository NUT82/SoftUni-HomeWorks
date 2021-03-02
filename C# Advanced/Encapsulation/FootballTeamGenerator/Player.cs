using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private readonly Stat stat;

        public Player(string name, Stat stat)
        {
            Name = name;
            this.stat = stat;
        }

        public string Name
        {
            get => name;
            private set
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, "A name should not be empty.");

                name = value;
            }
        }

        public double AverageStat
        {
            get => (stat.Dribble + stat.Endurance + stat.Passing + stat.Shooting + stat.Sprint) / 5.00;
        }
    }
}
