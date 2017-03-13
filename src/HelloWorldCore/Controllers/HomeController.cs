using HelloWorldCore.Models;
using HelloWorldCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldCore.Controllers
{
    public class HomeController : Controller
    {
        private IPokemonData _pokemonData;

        public HomeController(IPokemonData pokemonData)
        {
            _pokemonData = pokemonData;
        }
        
        public IActionResult Index()
        {
            var model = _pokemonData.GetAll();

            return View(model);
        }
    }
}
