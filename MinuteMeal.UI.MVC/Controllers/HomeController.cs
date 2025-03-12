using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinuteMeal.UI.MVC.Context;
using MinuteMeal.UI.MVC.Models;

namespace MinuteMeal.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly RecipeDbContext _context;

        public HomeController(RecipeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var recipes = _context.Recipes.ToList();
            return View(recipes);
        }

        public IActionResult Detail(int id)
        {
            var recipe = _context.Recipes.Find(id);
            return View(recipe);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
