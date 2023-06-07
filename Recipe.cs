using System;

namespace BookRecipe.Models
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public DateTime CreatedAt { get; set; }

        public Recipe(string title, string ingredients, string instructions)
        {
            Title = title;
            Ingredients = ingredients;
            Instructions = instructions;
            CreatedAt = DateTime.Now;
        }
    }
}