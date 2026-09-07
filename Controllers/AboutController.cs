using Microsoft.AspNetCore.Mvc;

namespace LTWLesson04.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Mai Anh";
            ViewData["age"] = 20;
            TempData["address"] = "Ha Noi";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
