using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Person> peoples = new Dictionary<string, Person>();
            
            string command = Console.ReadLine();
            while (command != "Results")
            {
                string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string currCommand = tokens[0];
                string name = tokens[1];
                switch (currCommand)
                {
                    case "Add":
                        int health = int.Parse(tokens[2]);
                        int energy = int.Parse(tokens[3]);
                        if (!peoples.ContainsKey(name))
                        {
                            peoples.Add(name, new Person(name, health, energy));
                        }
                        else
                        {
                            peoples[name].Health += health;
                        }
                        break;
                    case "Attack":
                        string attackerName = name;
                        string defenderName = tokens[2];
                        int damage = int.Parse(tokens[3]);
                        if (peoples.ContainsKey(attackerName) && peoples.ContainsKey(defenderName))
                        {
                            Person attacker = peoples[attackerName];
                            Person defender = peoples[defenderName];
                            defender.Health -= damage;
                            if (defender.Health <= 0)
                            {
                                peoples.Remove(defenderName);
                                Console.WriteLine($"{defenderName} was disqualified!");
                            }
                            attacker.Energy--;
                            if (attacker.Energy == 0)
                            {
                                peoples.Remove(attackerName);
                                Console.WriteLine($"{attackerName} was disqualified!");
                            }
                        }
                        break;
                    case "Delete":
                        if (name == "All")
                        {
                            peoples.Clear();
                        }
                        else
                        {
                            peoples.Remove(name);
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"People count: {peoples.Count}");
            foreach (var person in peoples.OrderByDescending(h => h.Value.Health).ThenBy(n => n.Key))
            {
                Console.WriteLine(person.Value);
            }
        }

        public class Person
        {
            public Person(string name, int health, int energy)
            {
                Name = name;
                Health = health;
                Energy = energy;
            }

            public string Name { get; set; }

            public int Health { get; set; }

            public int Energy { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Health} - {Energy}";
            }
        }
    }
}
