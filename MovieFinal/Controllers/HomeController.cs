using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieFinal.Models;
using System.Diagnostics;

namespace MovieFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var movies = context.Movies
                .Include(m => m.Genre)
                .OrderBy(m => m.Name)
                .ToList();

            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Movies()
        {
            return View();
        }

        [Route("genres")]
        public IActionResult Genres()
        {
            var genres = context.Genres
                .OrderBy(g => g.Name)
                .ToList();

            return View(genres);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    

        
    }


