using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinuteMeal.UI.MVC.Core;
using MinuteMeal.UI.MVC.Models;

namespace MinuteMeal.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly MinuteMealDatabase _database;

        public HomeController(MinuteMealDatabase database)
        {
            _database = database;
        }

        public IActionResult Index()
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
