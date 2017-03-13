using HelloWorldCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldCore.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            var model = new Pokemon { Id = 0, Name = "Mudkip" };

            return View(model);
        }
    }
}
