using MinuteMeal.UI.MVC.Models;

namespace MinuteMeal.UI.MVC.Core
{
    public class MinuteMealDatabase
    {
        public IList<Recipe> Recipes { get; set; }


        public Seed()
        {
            Recipes = new List<Recipe>
            {
                new Recipe
                {
                    Name = "Spaghetti Carbonara",
                    Ingredients = "Spaghetti, eggs, pancetta, parmesan cheese, black pepper",
                    Steps = "Cook spaghetti, fry pancetta, mix eggs and cheese, combine all ingredients",
                    CookingTimeInMinutes = 20
                },
                new Recipe
                { }

            }
            }
    }
}
