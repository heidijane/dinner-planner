using System;

namespace dinnerPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            CookBook dinnerCookbook = new CookBook();

            Recipe frittata = new Recipe("Kale & Chorizo Frittata")
            {
                NumOfMeals = 2,
                Chef = "Heidi"
            };
            frittata.AddIngredient("10 oz. chorizo");
            frittata.AddIngredient("1 bunch kale");
            frittata.AddIngredient("4 large eggs");
            frittata.AddIngredient("1 cup milk");
            frittata.AddIngredient("1/4 cup grated parmesan");
            frittata.AddIngredient("1 cup shredded mozzarella");

            dinnerCookbook.AddRecipe(frittata);

            dinnerCookbook.DisplayCookbook();
        }
    }
}