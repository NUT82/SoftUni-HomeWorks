using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Player> playersPool = new SortedDictionary<string, Player>();
            string command = Console.ReadLine();
            while (command != "Season end")
            {
                bool isBattle = (command.Split().Length == 3);
                if (isBattle)
                {
                    string playerOne = command.Split()[0];
                    string playerTwo = command.Split()[2];
                    if (playersPool.ContainsKey(playerOne) && playersPool.ContainsKey(playerTwo))
                    {
                        string samePosition = playersPool[playerOne].SamePosition(playersPool[playerTwo]);
                        if (samePosition != "")
                        {
                            if (playersPool[playerOne].PositionsAndSkills[samePosition] > playersPool[playerTwo].PositionsAndSkills[samePosition])
                            {
                                //playerOne Win - playerTwo is demoted
                                playersPool.Remove(playerTwo);
                            }
                            else if (playersPool[playerOne].PositionsAndSkills[samePosition] < playersPool[playerTwo].PositionsAndSkills[samePosition])
                            {
                                //playerTwo Win - playerOne is demoted
                                playersPool.Remove(playerOne);
                            }
                        }
                    }
                }
                else
                {
                    string name = command.Split(" -> ")[0];
                    string position = command.Split(" -> ")[1];
                    int skill = int.Parse(command.Split(" -> ")[2]);
                    if (playersPool.ContainsKey(name))
                    {
                        if (playersPool[name].PositionsAndSkills.ContainsKey(position))
                        {
                            if (skill > playersPool[name].PositionsAndSkills[position])
                            {
                                playersPool[name].PositionsAndSkills[position] = skill;
                            }
                        }
                        else
                        {
                            playersPool[name].PositionsAndSkills.Add(position, skill);
                        }
                    }
                    else
                    {
                        Player player = new Player(name, position, skill);
                        playersPool.Add(name, player);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var player in playersPool.OrderByDescending(p => p.Value.PositionsAndSkills.Values.Sum()))
            {
                Console.WriteLine($"{player.Key}: {player.Value.PositionsAndSkills.Values.Sum()} skill");
                foreach (var position in player.Value.PositionsAndSkills.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public SortedDictionary<string, int> PositionsAndSkills { get; set; } // <position, skills>
        public Player(string name, string position, int skill)
        {
            Name = name;
            PositionsAndSkills = new SortedDictionary<string, int>() { { position, skill } };
        }

        internal string SamePosition(Player player)
        {
            List<string> positions = new List<string>();
            foreach (var item in this.PositionsAndSkills)
            {
                positions.Add(item.Key);
            }

            foreach (var item in player.PositionsAndSkills.Keys)
            {
                if (positions.Contains(item))
                {
                    return item;
                }
            }

            return "";
        }
    }
}
