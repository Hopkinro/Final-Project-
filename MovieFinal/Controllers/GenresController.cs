using Microsoft.AspNetCore.Mvc;

namespace MovieFinal.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
