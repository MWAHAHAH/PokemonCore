using HelloWorldCore.Entities;
using System.Collections.Generic;

namespace HelloWorldCore.ViewModels
{
    public class HomePageViewModel
    {
        public string CurrentMessage { get; set; }
        public IEnumerable<Pokemon> Pokemons { get; set; }
    }
}
