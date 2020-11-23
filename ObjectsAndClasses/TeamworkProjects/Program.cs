using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>(countOfTeams);

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] currLine = Console.ReadLine().Split("-");
                string currTeamCreator = currLine[0];
                string currTeamName = currLine[1];
                if (Team.isNewName(currTeamName, teams) != -1)
                {
                    Console.WriteLine($"Team {currTeamName} was already created!");
                    continue;
                }
                if (!Team.isNewCreator(currTeamCreator, teams))
                {
                    Console.WriteLine($"{currTeamCreator} cannot create another team!");
                    continue;
                }

                Team team = new Team(currTeamCreator, currTeamName);
                teams.Add(team);
                Console.WriteLine($"Team {currTeamName} has been created by {currTeamCreator}!");
            }

            string commandLine = Console.ReadLine();
            while (commandLine != "end of assignment")
            {
                string[] command = commandLine.Split("->");
                string user = command[0];
                string joiningTeam = command[1];
                int index = Team.isNewName(joiningTeam, teams);
                if (index == -1)
                {
                    Console.WriteLine($"Team {joiningTeam} does not exist!");
                    commandLine = Console.ReadLine();
                    continue;
                }
                if (Team.userExist(user, teams))
                {
                    Console.WriteLine($"Member {user} cannot join team {joiningTeam}!");
                    commandLine = Console.ReadLine();
                    continue;
                }

                teams[index].Members.Add(user);
                commandLine = Console.ReadLine();
            }

            if (Team.isTeamWhitMembers(teams))
            {
                foreach (Team team in teams.Where(x => x.Members.Count != 1).OrderBy(y => y.Name).OrderByDescending(x => x.Members.Count))
                {
                    Console.WriteLine(team.ToString());
                }
            }

            Console.WriteLine("Teams to disband:");
            if (Team.isTeamWithoutMembers(teams))
            {
                foreach (Team team in teams.Where(x => x.Members.Count == 1).OrderBy(y => y.Name))
                {
                    Console.WriteLine(team.Name);
                }
            }
        }
    }

    public class Team
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }

        public Team(string creator, string name)
        {
            this.Creator = creator;
            this.Name = name;
            this.Members = new List<string>();
            this.Members.Add(creator); // first member is creator of Team
        }

        internal static bool isNewCreator(string currCreator, List<Team> teams)
        {
            foreach (Team item in teams.Where(x => x.Creator == currCreator))
            {
                return false;
            }

            return true;
        }

        internal static int isNewName(string currName, List<Team> teams)
        {
            foreach (Team item in teams.Where(x => x.Name == currName))
            {
                return teams.IndexOf(item);
            }

            return -1;
        }

        internal static bool userExist(string user, List<Team> teams)
        {
            foreach (Team team in teams)
            {
                if (team.Members.Contains(user))
                {
                    return true;
                }
            }

            return false;
        }

        internal static bool isTeamWithoutMembers(List<Team> teams)
        {
            foreach (var item in teams)
            {
                if (item.Members.Count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        internal static bool isTeamWhitMembers(List<Team> teams)
        {
            foreach (var item in teams)
            {
                if (item.Members.Count != 1)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            /*
             {teamName}:
             - {creator}
             -- {member}…
            */
            StringBuilder team = new StringBuilder();
            team.AppendLine($"{this.Name}");
            team.AppendLine($"- {this.Creator}");
            List<string> members = this.Members.Skip(1).ToList();
            members.Sort();
            foreach (var item in members)
            {
                team.AppendLine($"-- {item}");
            }
            
            return team.ToString().Trim();
        }
    }
}
