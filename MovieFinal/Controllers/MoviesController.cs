using Microsoft.AspNetCore.Mvc;

namespace MovieFinal.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
