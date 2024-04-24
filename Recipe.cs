public class Recipe
{
    public List<int> Ingredients { get; set; }

    public static void CreateRecipe()
    {
        List<int> ingredientsList = new List<int>();

        string userChoice;
        int numberOfIngredients = 0;
        do
        {
            Console.WriteLine("Add an ingredient by it's Id or type anything else if finished.");
            userChoice = Console.ReadLine();

            switch (int.Parse(userChoice))
            {
                case (int)IngredientsId.Wheat:
                    ingredientsList.Add(1);
                    break;
                case (int)IngredientsId.Butter:
                    ingredientsList.Add(2);
                    break;
                case (int)IngredientsId.Chocolate:
                    ingredientsList.Add(3);
                    break;
                case (int)IngredientsId.Cinnamon:
                    ingredientsList.Add(4);
                    break;
            }

            numberOfIngredients++;

        } while (int.Parse(userChoice) < Ingredient.NumberOfIngredients);

        if (numberOfIngredients == 1)
        {
            Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
        }

        var newRecipe = new Recipe
        {
            Ingredients = ingredientsList
        };

        SaveFile.Json(newRecipe);

    }
}