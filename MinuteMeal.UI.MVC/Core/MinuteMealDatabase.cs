using MinuteMeal.UI.MVC.Models;

namespace MinuteMeal.UI.MVC.Core
{
    public class MinuteMealDatabase
    {
        public IList<Recipe> Recipes { get; set; }



        public void Seed()
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
                {
                    Name = "Chicken Alfredo",
                    Ingredients = "Fettuccine, chicken, heavy cream, parmesan cheese, garlic",
                    Steps = "Cook fettuccine, fry chicken, mix cream and cheese, combine all ingredients",
                    CookingTimeInMinutes = 30
                },
                new Recipe
                {
                    Name = "Beef Stroganoff",
                    Ingredients = "Egg noodles, beef, sour cream, mushrooms, onion",
                    Steps = "Cook noodles, fry beef, saute mushrooms and onion, combine all ingredients",
                    CookingTimeInMinutes = 25
                },
                new Recipe
                {
                    Name = "Chicken Parmesan",
                    Ingredients = "Chicken, breadcrumbs, marinara sauce, mozzarella cheese",
                    Steps = "Bread chicken, fry chicken, top with sauce and cheese, bake",
                    CookingTimeInMinutes = 40
                },
                new Recipe
                {
                    Name = "Chicken Stir Fry",
                    Ingredients = "Chicken, vegetables, soy sauce, garlic, ginger",
                    Steps = "Cook chicken, saute vegetables, add sauce, combine all ingredients",
                    CookingTimeInMinutes = 15
                },
                new Recipe
                {
                    Name = "Chicken Tacos",
                    Ingredients = "Chicken, tortillas, salsa, lettuce, cheese",
                    Steps = "Cook chicken, warm tortillas, top with salsa, lettuce, and cheese",
                    CookingTimeInMinutes = 20
                },
                new Recipe
                {
                    Name = "Chicken Curry",
                    Ingredients = "Chicken, curry paste, coconut milk, vegetables",
                    Steps = "Cook chicken, add curry paste and coconut milk, simmer with vegetables",
                    CookingTimeInMinutes = 30
                },
                new Recipe
                {
                    Name = "Chicken Noodle Soup",
                    Ingredients = "Chicken, egg noodles, carrots, celery, onion",
                    Steps = "Cook chicken, saute vegetables, add broth and noodles, simmer",
                    CookingTimeInMinutes = 45
                },
                new Recipe
                {
                    Name = "Chicken Salad",
                    Ingredients = "Chicken, lettuce, tomatoes, cucumbers, dressing",
                    Steps = "Cook chicken, chop vegetables, combine all ingredients",
                    CookingTimeInMinutes = 10
                },
                new Recipe
                {
                    Name = "Chicken Quesadillas",
                    Ingredients = "Chicken, tortillas, cheese, salsa, sour cream",
                    Steps = "Cook chicken, warm tortillas, top with cheese, salsa, and sour cream",
                    CookingTimeInMinutes = 20
                }
            };
        }
    }
}
