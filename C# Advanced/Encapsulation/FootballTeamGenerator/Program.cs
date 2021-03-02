using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splitCommand = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string currCommand = splitCommand[0];
                string teamName = splitCommand[1];
                try
                {
                    if (!teams.ContainsKey(teamName) && currCommand != "Team")
                    {
                        throw new ArgumentException($"Team {teamName} does not exist.");
                    }

                    switch (currCommand)
                    {
                        case "Team":
                            teams.Add(teamName, new Team(teamName));
                            break;
                        case "Add":
                            string playerName = splitCommand[2];
                            int endurance = int.Parse(splitCommand[3]);
                            int sprint = int.Parse(splitCommand[4]);
                            int dribble = int.Parse(splitCommand[5]);
                            int passing = int.Parse(splitCommand[6]);
                            int shooting = int.Parse(splitCommand[7]);
                            teams[teamName].AddPlayer(  new Player(playerName, 
                                                        new Stat(endurance, sprint, dribble, passing, shooting)));
                            break;
                        case "Remove":
                            playerName = splitCommand[2];
                            teams[teamName].RemovePlayer(playerName);
                            break;
                        case "Rating":
                            Console.WriteLine($"{teamName} - {teams[teamName].Rating}"); 
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                command = Console.ReadLine();
            }
        }
    }
}
