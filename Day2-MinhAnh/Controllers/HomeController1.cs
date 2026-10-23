using Microsoft.AspNetCore.Mvc;

namespace Day2_MinhAnh.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numtimes = 1)
        {
            ViewBag.Massage = "Hello" + name;
            ViewData["numtimes"] = numtimes;
            return View();
            
        }
    }
}
