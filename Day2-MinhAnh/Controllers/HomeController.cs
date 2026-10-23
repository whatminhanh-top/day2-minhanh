using day2_minhanh.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace day2_minhanh.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var courses = new List<Course>
            {
                new Course { Id = 1, Title = "Lập trình C# cơ bản", DurationHours = 30 },
                new Course { Id = 2, Title = "ASP.NET Core MVC nâng cao", DurationHours = 45 },
                new Course { Id = 3, Title = "Cơ sở dữ liệu SQL Server", DurationHours = 25 }
            };

            return View(courses);
        }

        public IActionResult Privacy()
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