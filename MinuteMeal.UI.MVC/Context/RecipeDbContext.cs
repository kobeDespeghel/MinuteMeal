using Microsoft.EntityFrameworkCore;
using MinuteMeal.UI.MVC.Models;

namespace MinuteMeal.UI.MVC.Context
{
    public class RecipeDbContext: DbContext
    {
        public RecipeDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Recipe> Recipes { get; set; }

        public void Seed()
        {
            Recipes.AddRange(
                new Recipe
                {
                    Id = 1,
                    Name = "Spaghetti Carbonara",
                    Ingredients = "Spaghetti, eggs, pancetta, parmesan cheese, black pepper",
                    Steps = "Cook spaghetti, fry pancetta, mix eggs and cheese, combine all ingredients",
                    CookingTimeInMinutes = 20
                },
                new Recipe
                {
                    Id = 2,
                    Name = "Chicken Alfredo",
                    Ingredients = "Fettuccine, chicken, heavy cream, parmesan cheese, garlic",
                    Steps = "Cook fettuccine, fry chicken, mix cream and cheese, combine all ingredients",
                    CookingTimeInMinutes = 30
                },
                new Recipe
                {
                    Id = 3,
                    Name = "Beef Stroganoff",
                    Ingredients = "Egg noodles, beef, sour cream, mushrooms, onion",
                    Steps = "Cook noodles, fry beef, saute mushrooms and onion, combine all ingredients",
                    CookingTimeInMinutes = 25
                },
                new Recipe
                {
                    Id = 4,
                    Name = "Chicken Parmesan",
                    Ingredients = "Chicken, breadcrumbs, marinara sauce, mozzarella cheese",
                    Steps = "Bread chicken, fry chicken, top with sauce and cheese, bake",
                    CookingTimeInMinutes = 40
                },
                new Recipe
                {
                    Id = 5,
                    Name = "Chicken Stir Fry",
                    Ingredients = "Chicken, vegetables, soy sauce, garlic, ginger",
                    Steps = "Cook chicken, saute vegetables, add sauce, combine all ingredients",
                    CookingTimeInMinutes = 15
                },
                new Recipe
                {
                    Id = 6,
                    Name = "Chicken Tacos",
                    Ingredients = "Chicken, tortillas, salsa, lettuce, cheese",
                    Steps = "Cook chicken, warm tortillas, top with salsa, lettuce, and cheese",
                    CookingTimeInMinutes = 20
                },
                new Recipe
                {
                    Id = 7,
                    Name = "Chicken Curry",
                    Ingredients = "Chicken, curry paste, coconut milk, vegetables",
                    Steps = "Cook chicken, add curry paste and coconut milk, simmer with vegetables",
                    CookingTimeInMinutes = 30
                },
                new Recipe
                {
                    Id = 8,
                    Name = "Chicken Noodle Soup",
                    Ingredients = "Chicken, egg noodles, carrots, celery, onion",
                    Steps = "Cook chicken, saute vegetables, add broth and noodles, simmer",
                    CookingTimeInMinutes = 45
                },
                new Recipe
                {
                    Id = 9,
                    Name = "Chicken Salad",
                    Ingredients = "Chicken, lettuce, tomatoes, cucumbers, dressing",
                    Steps = "Cook chicken, chop vegetables, combine all ingredients",
                    CookingTimeInMinutes = 10
                },
                new Recipe
                {
                    Id = 10,
                    Name = "Chicken Quesadillas",
                    Ingredients = "Chicken, tortillas, cheese, salsa, sour cream",
                    Steps = "Cook chicken, warm tortillas, top with cheese, salsa, and sour cream",
                    CookingTimeInMinutes = 20
                }
                );
            
        }

    }
}
