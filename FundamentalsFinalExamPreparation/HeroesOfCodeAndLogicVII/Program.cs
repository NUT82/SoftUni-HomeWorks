using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] heroInput = Console.ReadLine().Split();
                string name = heroInput[0];
                int HP = int.Parse(heroInput[1]);
                int MP = int.Parse(heroInput[2]);
                heroes.Add(name, new Hero(name, HP, MP));
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string currCommand = tokens[0];
                string name = tokens[1];
                Hero currHero = heroes[name];

                switch (currCommand)
                {
                    case "CastSpell":
                        int neededMP = int.Parse(tokens[2]);
                        string spellName = tokens[3];
                        currHero.CastSpell(neededMP, spellName);
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(tokens[2]);
                        string attacker = tokens[3];
                        if (currHero.TakeDamage(damage, attacker) <= 0)
                        {
                            heroes.Remove(name);
                        }
                        break;
                    case "Recharge":
                        int amountMP = int.Parse(tokens[2]);
                        currHero.Recharge(amountMP);
                        break;
                    case "Heal":
                        int amountHP = int.Parse(tokens[2]);
                        currHero.Heal(amountHP);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes.OrderByDescending(h => h.Value.HP).ThenBy(n => n.Key))
            {
                Console.WriteLine(hero.Value);
            }
        }

        public class Hero
        {
            const int maxHP = 100;
            const int maxMP = 200;

            public Hero(string name, int hp, int mp)
            {
                Name = name;
                HP = hp;
                MP = mp;
            }

            public string Name { get; private set; }

            public int HP { get; private set; }

            public int MP { get; private set; }

            internal void CastSpell(int neededMP, string spellName)
            {
                if (MP >= neededMP)
                {
                    MP -= neededMP;
                    Console.WriteLine($"{Name} has successfully cast {spellName} and now has {MP} MP!");
                }
                else
                {
                    Console.WriteLine($"{Name} does not have enough MP to cast {spellName}!");
                }
            }

            internal void Heal(int amountHP)
            {
                int recoveredHP = amountHP;
                HP += amountHP;
                if (HP > maxHP)
                {
                    recoveredHP -= HP - maxHP;
                    HP = maxHP;
                }

                Console.WriteLine($"{Name} healed for {recoveredHP} HP!");
            }

            internal void Recharge(int amountMP)
            {
                int recoveredMP = amountMP;
                MP += amountMP;
                if (MP > maxMP)
                {
                    recoveredMP -= MP - maxMP;
                    MP = maxMP;
                }

                Console.WriteLine($"{Name} recharged for {recoveredMP} MP!");
            }

            internal int TakeDamage(int damage, string attacker)
            {
                HP -= damage;
                if (HP > 0)
                {
                    Console.WriteLine($"{Name} was hit for {damage} HP by {attacker} and now has {HP} HP left!");
                }
                else
                {
                    Console.WriteLine($"{Name} has been killed by {attacker}!");
                }

                return HP;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(Name);
                sb.AppendLine($"  HP: {HP}");
                sb.AppendLine($"  MP: {MP}");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
