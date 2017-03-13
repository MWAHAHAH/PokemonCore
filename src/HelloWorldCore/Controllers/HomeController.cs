using HelloWorldCore.Services;
using HelloWorldCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldCore.Controllers
{
    public class HomeController : Controller
    {
        private IPokemonData _pokemonData;
        private IGreeter _greeter;

        public HomeController(IPokemonData pokemonData, IGreeter greeter)
        {
            _pokemonData = pokemonData;
            _greeter = greeter;
        }
        
        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Pokemons = _pokemonData.GetAll();
            model.CurrentMessage = _greeter.GetGreeting();

            return View(model);
        }
    }
}
