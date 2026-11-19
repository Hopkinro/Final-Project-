using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieFinal.Models;
using MovieFinal.Data;
using System.Diagnostics;

namespace MovieFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieContext _context;

        public HomeController(
            ILogger<HomeController> logger,
            MovieContext context)
        {
            _logger = logger;
            _context = context;
        }
       
        public IActionResult Index()
        {
            var movies = _context.Movies
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
            return View();
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


