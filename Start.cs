using CookiesCookbook;

public static class Start
{
    public static void StartProgram()
    {
        ReadFile.ReadTxt();
        ReadFile.ReadJson();
        Console.WriteLine("Create a new recipe! Available ingredients are: ");
        AllIngredients.PrintIngredients();
        Recipe.CreateRecipe();
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}