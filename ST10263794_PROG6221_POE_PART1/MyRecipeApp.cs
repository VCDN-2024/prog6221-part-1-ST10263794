using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10263794_PROG6221_POE_PART1
{
    // Class to manage the recipe application
    internal class MyRecipeApp
    {
        private Recipe recipe;
        private double[] originalQuantities; // Array to store original quantities

        // Method to enter recipe details
        public void RecipeDetails()
        {
            recipe = new Recipe();

            Console.WriteLine("Enter the recipe name:");
            recipe.name = Console.ReadLine();

            Console.WriteLine("Enter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());
            recipe.Ingredients = new Ingredients[numIngredients];

            // Loop to enter details for each ingredient
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


            // Store original quantities
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

        // Method to display the recipe with colored text
        public void RecipeDisplay()
        {
            Console.WriteLine($"Recipe: {recipe.name}");
            Console.WriteLine("Ingredients:");

            // Display each ingredient
            foreach (var ingredients in recipe.Ingredients)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{ingredients.quantity} {ingredients.unit} of ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ingredients.name);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Steps:");

            // Display each step
            for (int i = 0; i < recipe.Steps.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{i + 1}. {recipe.Steps[i]}");
            }

            // Reset console color
            Console.ForegroundColor = ConsoleColor.White;

        }

        // Method to scale the recipe by a given factor
        public void RecipeScale(double factor)
        {
            foreach (var ingredients in recipe.Ingredients)
            {
                ingredients.quantity *= factor;
            }
        }

        // Method to reset ingredient quantities to original values
        public void RecipeQuantitiesReset()
        {
            if (recipe != null && recipe.Ingredients != null)
            {

                // Loop through each ingredient and reset its quantity to the original value
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

        // Dummy method to simulate retrieving original quantities based on initial user input
        private double[] GetOriginalQuantities(Ingredients[] ingredients)
        {
            if (ingredients != null)
            {
                // Create an array to store original quantities
                double[] originalQuantities = new double[ingredients.Length];

                // Loop through each ingredient and store its original quantity
                for (int i = 0; i < ingredients.Length; i++)
                {
                    originalQuantities[i] = ingredients[i].quantity;
                }

                return originalQuantities;
            }
            else
            {
                // Return an empty array if ingredients array is null
                return new double[0];
            }
        }

        // Method to clear all data
        public void ClearRecipeData()
        {
            recipe = null;
            originalQuantities = null;
        }

    }

}

