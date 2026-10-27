using Microsoft.AspNetCore.Mvc;

namespace MovieFinal.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
