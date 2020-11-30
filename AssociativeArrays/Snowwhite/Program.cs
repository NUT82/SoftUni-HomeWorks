using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dwarf>> dwarfs = new Dictionary<string, List<Dwarf>>(); //<color, <name, Dwarf>>
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
                        if (dwarfs[hatColor].Find(n => n.Name == name).Physics < physics)
                        {
                            dwarfs[hatColor].Find(n => n.Name == name).Physics = physics;
                        }
                    }
                    else
                    {
                        dwarfs[hatColor].Add(dwarf);
                    }
                }
                else
                {
                    dwarfs.Add(hatColor, new List<Dwarf>() { dwarf });
                }

                command = Console.ReadLine();
            }


            foreach (var item in dwarfs.Values.OrderByDescending(x => x[0].Physics).ThenByDescending(h => h.Count()))
            {
                foreach (var ddd in item.OrderByDescending(x => x.Physics).ThenByDescending(x => item.Count()))
                {
                    Console.WriteLine($"({ddd.HatColor}) {ddd.Name} <-> {ddd.Physics}");
                }
                //for (int i = 0; i < item.Count; i++)
                //{
                //    Console.WriteLine($"({item[i].HatColor}) {item[i].Name} <-> {item[i].Physics}");
                //}
                
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
}
