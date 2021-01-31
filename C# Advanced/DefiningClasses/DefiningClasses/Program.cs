using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string command = Console.ReadLine();
            while (command != "Tournament")
            {
                string[] splitCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = splitCommand[0];
                string pokemonName = splitCommand[1];
                string pokemonElement = splitCommand[2];
                int pokemonHealth = int.Parse(splitCommand[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainerName, trainer);
                }
                trainers[trainerName].AddPokemon(pokemon);

                command = Console.ReadLine();
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string element = input;
                foreach (Trainer trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
