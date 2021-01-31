using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer()
        {
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }

        public Trainer(string name)
            :this()
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }
    }
}
