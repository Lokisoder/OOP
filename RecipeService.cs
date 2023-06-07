using System.Collections.Generic;
using System.Linq;
using BookRecipe.Models;

namespace BookRecipe.Services
{
    public class RecipeService
    {
        private List<Recipe> recipes;

        public RecipeService()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void RemoveRecipe(Recipe recipe)
        {
            recipes.Remove(recipe);
        }

        public List<Recipe> GetAllRecipes()
        {
            return recipes.ToList();
        }
    }
}