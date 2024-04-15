using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10263794_PROG6221_POE_PART1
{
    internal class MyRecipeApp
    {
        private Recipe recipe;

        public void RecipeDetails()
        {
            recipe = new Recipe();

            Console.WriteLine("Enter the recipe name:");
            recipe.name = Console.ReadLine();

            Console.WriteLine("Enter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());
            recipe.Ingredients = new Ingredients[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter name of ingredient {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter the quantity of {name}:");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter unit of measurement for {name}:");
                string unit = Console.ReadLine();

                recipe.Ingredients[i] = new Ingredients { name = name, quantity = quantity, unit = unit };

                {
                    Console.WriteLine($"Enter step {i + 1}:");
                    recipe.Steps[i] = Console.ReadLine();
                }
            }

            Console.WriteLine("Enter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine());
            recipe.Steps = new string[numSteps];

        }

        public void RecipeDisplay()
        {
            Console.WriteLine($"Recipe: {recipe.name}");
            Console.WriteLine("Ingredients:");

            foreach (var ingredients in recipe.Ingredients)
            {
                Console.WriteLine($"{ingredients.quantity} {ingredients.unit} of {ingredients.name}");
            }

            Console.WriteLine("Steps:");

            for (int i = 0; i < recipe.Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {recipe.Steps[i]}");
            }

        }

        public void RecipeScale(double factor)
        {
            foreach (var ingredients in recipe.Ingredients)
            {
                ingredients.quantity *= factor;
            }
        }

    }
}
