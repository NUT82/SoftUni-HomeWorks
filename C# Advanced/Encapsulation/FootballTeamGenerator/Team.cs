using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private Dictionary<string, Player> players;

        public Team(string name)
        {
            Name = name;
            players = new Dictionary<string, Player>();
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

        public int Rating
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }

                return (int)Math.Round(players.Values.Average(p => p.AverageStat), 0);
            }
        }

        public void AddPlayer(Player player)
        {
            if (players.ContainsKey(player.Name))
            {
                throw new ArgumentException($"Player {player.Name} already exist!");
            }

            players.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!players.ContainsKey(playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");
            }

            players.Remove(playerName);
        }
    }
}
