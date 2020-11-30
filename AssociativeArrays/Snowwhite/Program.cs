using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<Dwarf>> dwarfs = new Dictionary<string, SortedSet<Dwarf>>(); //<color, <name, Dwarf>>
            string command = Console.ReadLine();
            while (command != "Once upon a time")
            {
                string name = command.Split(" <:> ")[0];
                string hatColor = command.Split(" <:> ")[1];
                int physics = int.Parse(command.Split(" <:> ")[2]);
                Dwarf dwarf = new Dwarf(name, hatColor, physics);
                if (dwarfs.ContainsKey(hatColor))
                {
                    if (dwarfs[hatColor].Any(n => n.Name == name))
                    {
                        if (dwarfs[hatColor].Single(n => n.Name == name).Physics < physics)
                        {
                            dwarfs[hatColor].Single(n => n.Name == name).Physics = physics;
                        }
                    }
                    else
                    {
                        dwarfs[hatColor].Add(dwarf);
                    }
                }
                else
                {
                    dwarfs.Add(hatColor, new SortedSet<Dwarf>() { dwarf });
                }

                command = Console.ReadLine();
            }


            foreach (var dwarf in dwarfs.Values)
            {
                foreach (var item in dwarf)
                {
                    Console.WriteLine($"({item.HatColor}) {item.Name} <-> {item.Physics}");
                }
            }

            //Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
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

    public class DwarfCompare : IComparer<Dwarf>
    {
        public int Compare(Dwarf x, Dwarf y)
        {
            return x.Physics.CompareTo(y.Physics);
        }
    }
}
