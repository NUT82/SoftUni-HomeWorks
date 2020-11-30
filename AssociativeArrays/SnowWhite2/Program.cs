using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhite2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            string command = Console.ReadLine();
            while (command != "Once upon a time")
            {
                string name = command.Split(" <:> ")[0];
                string hatColor = command.Split(" <:> ")[1];
                int physics = int.Parse(command.Split(" <:> ")[2]);
                string nameAndHatColor = $"{name} {hatColor}";
                if (dwarfs.ContainsKey(nameAndHatColor))
                {
                    if (physics > dwarfs[nameAndHatColor])
                    {
                        dwarfs[nameAndHatColor] = physics;
                    }
                }
                else
                {
                    dwarfs.Add(nameAndHatColor, physics);
                }

                command = Console.ReadLine();
            }

            foreach (var item in dwarfs.OrderByDescending(p => p.Value).ThenByDescending(x => dwarfs.Where(y => y.Key.Split()[1] == x.Key.Split()[1]).Count()))
            {
                Console.WriteLine($"({item.Key.Split()[1]}) {item.Key.Split()[0]} <-> {item.Value}");
            }
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }
        public Dwarf(string name, string hatColor, int physics)
        {
            Name = name;
            HatColor = hatColor;
            Physics = physics;
        }
    }
}
