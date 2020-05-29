using System;
using System.Collections.Generic;

namespace dinnerPlan
{
    class Recipe
    {
        public string Name { get; }
        public List<string> Ingredients { get; } = new List<string>();
        public int NumOfMeals { get; set; } = 1; //how many dinners does this make
        public string Chef { get; set; } = "Anyone"; //person who can make this meal

        public Recipe(string name)
        {
            Name = name;
        }

        public void AddIngredient(string ingredient) => Ingredients.Add(ingredient);

        public void DisplayRecipe()
        {
            Console.WriteLine(Name);
            Console.WriteLine("--------------------");
            Console.WriteLine("Ingredients");
            Console.WriteLine("--------------------");
            Ingredients.ForEach(ingredient => Console.WriteLine(ingredient));
            Console.WriteLine("--------------------");
            Console.WriteLine($"Number of Meals: {NumOfMeals}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Can be made by {Chef}");
        }

    }
}