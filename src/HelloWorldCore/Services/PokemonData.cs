using HelloWorldCore.Entities;
using System.Collections.Generic;
using System;

namespace HelloWorldCore.Services
{
    public interface IPokemonData
    {
        IEnumerable<Pokemon> GetAll();
    }

    public class InMemoryPokemonData : IPokemonData
    {
        public InMemoryPokemonData()
        {
            _pokemon = new List<Pokemon>
            {
                new Pokemon {Id = 0, Name = "treeko" },
                new Pokemon {Id = 1, Name = "torcic"},
                new Pokemon {Id = 2, Name="mudkip" }
            };
        }

        List<Pokemon> _pokemon;

        public IEnumerable<Pokemon> GetAll()
        {
            return _pokemon;
        }
    }
}
