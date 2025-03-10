using Microsoft.AspNetCore.Mvc;
using MinuteMeal.UI.MVC.Core;

namespace MinuteMeal.UI.MVC.Controllers
{
    public class RecipeController : Controller
    {
        private readonly MinuteMealDatabase _database;

        public RecipeController(MinuteMealDatabase database)
        { 
            _database = database;
        }



        public IActionResult Index()
        {
            return View(_database.Recipes);
        }
    }
}
