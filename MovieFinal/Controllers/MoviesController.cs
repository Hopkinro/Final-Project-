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

        public IActionResult PopularMovies()
        {
            return View();
        }

        public IActionResult RecommendedMovies()
        {
            return View();
        }

        public IActionResult ReleasingMovies()
        {
            return View();
        }
    }
}
