using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<Hero>> typeAndHero = new Dictionary<string, SortedSet<Hero>>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split();
                Hero hero = new Hero(command[0], command[1], command[2], command[3], command[4]);
                if (typeAndHero.ContainsKey(command[0]))
                {
                    if (typeAndHero[command[0]].Any(n => n.Name == command[1]))
                    {
                        typeAndHero[command[0]].Single(n => n.Name == command[1]).ChangeStats(command[2], command[3], command[4]);
                    }
                    else
                    {
                        typeAndHero[command[0]].Add(hero);
                    }
                }
                else
                {
                    typeAndHero.Add(command[0], new SortedSet<Hero>(new HeroComparer()) { hero });
                }
            }

            foreach (var type in typeAndHero)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Average(d => d.Damage):F2}/{type.Value.Average(h => h.Health):F2}/{type.Value.Average(a => a.Armor):F2})");
                foreach (var hero in type.Value)
                {
                    Console.WriteLine($"-{hero.Name} -> damage: {hero.Damage}, health: {hero.Health}, armor: {hero.Armor}");
                }
            }
        }
    }

    public class Hero
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public Hero(string type, string name, string damage, string health, string armor)
        {
            Type = type;
            Name = name;
            ChangeStats(damage, health, armor);
        }

        internal void ChangeStats(string damage, string health, string armor)
        {
            Damage = damage != "null" ? int.Parse(damage) : 45;
            Health = health != "null" ? int.Parse(health) : 250;
            Armor = armor != "null" ? int.Parse(armor) : 10;
        }
    }

    public class HeroComparer : IComparer<Hero>
    {
        public int Compare(Hero x, Hero y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
