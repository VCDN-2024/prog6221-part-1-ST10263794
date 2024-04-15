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
        private double[] originalQuantities;
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

               
            }



            originalQuantities = GetOriginalQuantities(recipe.Ingredients);

            Console.WriteLine("Enter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine());
            recipe.Steps = new string[numSteps];

            // Loop to enter details for each step
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                recipe.Steps[i] = Console.ReadLine();
            }

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
      
        public void RecipeQuantitiesReset()
        {
            if (recipe != null && recipe.Ingredients != null)
            {
                
                for (int i = 0; i < recipe.Ingredients.Length; i++)
                {
                    if (originalQuantities.Length == recipe.Ingredients.Length)
                    {
                        recipe.Ingredients[i].quantity = originalQuantities[i];
                    }
                    else
                    {
                        Console.WriteLine("Error: Unable to reset quantities. Original quantities data is missing or corrupted.");
                        return;
                    }
                }

                Console.WriteLine("Ingredient quantities reset to original values.");
            }
            else
            {
                Console.WriteLine("Error: No recipe data available to reset quantities.");
            }
        }

        private double[] GetOriginalQuantities(Ingredients[] ingredients)
        {
            if (ingredients != null)
            {
                
                double[] originalQuantities = new double[ingredients.Length];

                for (int i = 0; i < ingredients.Length; i++)
                {
                    originalQuantities[i] = ingredients[i].quantity;
                }

                return originalQuantities;
            }
            else
            {
                return new double[0];
            }
        }
    }

}

