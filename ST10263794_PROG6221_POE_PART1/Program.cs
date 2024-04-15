using ST10263794_PROG6221_POE_PART1;

static void Main(string[] args)
{
    MyRecipeApp app = new MyRecipeApp();
    bool running = true;

    while (running)
    {
        Console.WriteLine("1. Enter recipe details");
        Console.WriteLine("2. Display recipe");
        Console.WriteLine("3. Scale recipe");
        Console.WriteLine("4. Reset quantities");
        Console.WriteLine("5. Clear data");
        Console.WriteLine("6. Exit");

        Console.WriteLine("Select an option:");
        int option = int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
                app.RecipeDetails();
                break;
        }
    }
}