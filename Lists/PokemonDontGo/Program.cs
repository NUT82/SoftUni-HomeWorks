using System;
using System.Collections.Generic;
using System.Linq;


namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distancesOfPokemons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int sum = 0;

            while (distancesOfPokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedElement = 0;

                if (index < 0)
                {
                    removedElement = distancesOfPokemons[0];
                    distancesOfPokemons[0] = distancesOfPokemons[distancesOfPokemons.Count - 1];
                }
                else if (index > distancesOfPokemons.Count - 1)
                {
                    removedElement = distancesOfPokemons[distancesOfPokemons.Count - 1];
                    distancesOfPokemons[distancesOfPokemons.Count - 1] = distancesOfPokemons[0];
                }
                else
                {
                    removedElement = distancesOfPokemons[index];
                    distancesOfPokemons.RemoveAt(index);
                }

                sum += removedElement;

                for (int i = 0; i < distancesOfPokemons.Count; i++)
                {
                    if (distancesOfPokemons[i] <= removedElement)
                    {
                        distancesOfPokemons[i] += removedElement;
                    }
                    else
                    {
                        distancesOfPokemons[i] -= removedElement;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
