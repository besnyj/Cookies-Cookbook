public static class AllIngredients
{
    public static readonly List<Ingredient> AllIngredientsList = new List<Ingredient>()
    {
        new Wheat(),
        new Butter(),
        new Chocolate(),
        new Cinnamon()
    };

    public static void PrintIngredients()
    {
        foreach (var ingredient in AllIngredientsList)
        {
            Console.WriteLine($"{(int)ingredient.Id}. {ingredient.Name}");
        }
    }
}