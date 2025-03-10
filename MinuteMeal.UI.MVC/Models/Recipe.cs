namespace MinuteMeal.UI.MVC.Models
{
    public class Recipe
    {
        public required string Name { get; set; }
        public required string Ingredients { get; set; }
        public required string Steps { get; set; }
        public int CookingTimeInMinutes { get; set; }
    }
}