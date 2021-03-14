using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            BaseHeroCreator heroCreator = null;

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                try
                {
                    switch (type)
                    {
                        case "Druid":
                            heroCreator = new DruidCreator(name);
                            break;
                        case "Paladin":
                            heroCreator = new PaladinCreator(name);
                            break;
                        case "Rogue":
                            heroCreator = new RogueCreator(name);
                            break;
                        case "Warrior":
                            heroCreator = new WarriorCreator(name);
                            break;
                        default:
                            i--;
                            throw new ArgumentException("Invalid hero!");
                    }

                    heroes.Add(heroCreator.GetBaseHero());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            int bossPower = int.Parse(Console.ReadLine());

            int heroesPower = heroes.Sum(h => h.Power);
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (bossPower > heroesPower)
            {
                Console.WriteLine("Defeat...");
            }
            else
            {
                Console.WriteLine("Victory!");
            }
        }
    }
}
