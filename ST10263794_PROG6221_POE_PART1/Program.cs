using ST10263794_PROG6221_POE_PART1;

// Main program class
static void Main(string[] args)
{
    MyRecipeApp app = new MyRecipeApp();
    bool running = true;

    // Main program loop
    while (running)
    {
        // Display menu options
        Console.WriteLine("1. Enter recipe details");
        Console.WriteLine("2. Display recipe");
        Console.WriteLine("3. Scale recipe");
        Console.WriteLine("4. Reset quantities");
        Console.WriteLine("5. Clear data");
        Console.WriteLine("6. Exit");

        Console.WriteLine("Select an option:");
        int option = int.Parse(Console.ReadLine());

        // Switch statement to handle user input
        switch (option)
        {
            //Case statements for whichever option the user chooses
            case 1:
                app.RecipeDetails();
                break;

            case 2:
                app.RecipeDisplay();
                break;

            case 3:
                Console.WriteLine("Enter scale factor:");
                double factor = double.Parse(Console.ReadLine());
                app.RecipeScale(factor);
                break;

            case 4:
                app.RecipeQuantitiesReset();
                break;

            case 5:
                app.ClearRecipeData();
                break;

            case 6:
                running = false;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}