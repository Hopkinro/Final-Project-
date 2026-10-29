using Microsoft.AspNetCore.Mvc;

namespace MovieFinal.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Movies", "Genres");
        }

        public IActionResult Movies()
        {
            return View();
        }

        public IActionResult Genres()
        {
            return View();
        }
    }
}
