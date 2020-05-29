using System;
using System.Collections.Generic;

namespace dinnerPlan
{
    class CookBook
    {
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }
        public void DisplayCookbook()
        {
            Recipes.ForEach(recipe => recipe.DisplayRecipe());
        }

    }
}