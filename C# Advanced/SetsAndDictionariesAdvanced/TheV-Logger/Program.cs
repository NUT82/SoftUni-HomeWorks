using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vloger> vlogers = new Dictionary<string, Vloger>();

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] splitedInput = input.Split();
                string vlogerName = splitedInput[0];
                string command = splitedInput[1];
                
                if (command == "joined")
                {
                    if (!vlogers.ContainsKey(vlogerName))
                    {
                        Vloger vloger = new Vloger(vlogerName);
                        vlogers.Add(vlogerName, vloger);
                    }
                }
                else
                {
                    string vlogerFolowName = splitedInput[2];
                    if (vlogers.ContainsKey(vlogerName) && vlogers.ContainsKey(vlogerFolowName) && vlogerName != vlogerFolowName)
                    {
                        vlogers[vlogerName].Following.Add(vlogerFolowName);
                        vlogers[vlogerFolowName].Followers.Add(vlogerName);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var item in vlogers.OrderByDescending(v => v.Value.Followers.Count).ThenBy(v => v.Value.Following.Count))
            {
                Console.WriteLine($"{count}. {item.Key} : {item.Value.Followers.Count} followers, {item.Value.Following.Count} following");
                if (count == 1)
                {
                    foreach (var follower in item.Value.Followers.OrderBy(n => n))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                
                count++;
            }
        }
    }

    class Vloger
    {
        public string Name { get; set; }
        public HashSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }

        public Vloger(string name)
        {
            this.Name = name;
            this.Followers = new HashSet<string>();
            this.Following = new HashSet<string>();
        }
    }
}
