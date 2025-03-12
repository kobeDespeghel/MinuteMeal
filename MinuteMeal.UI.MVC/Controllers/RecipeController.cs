using Microsoft.AspNetCore.Mvc;
using MinuteMeal.UI.MVC.Context;

namespace MinuteMeal.UI.MVC.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeDbContext _context;

        public RecipeController(RecipeDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            var recipes = _context.Recipes.ToList();
            return View(recipes);
        }
    }
}
