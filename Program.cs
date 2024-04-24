Start.StartProgram();

public enum IngredientsId
{
    Wheat,
    Butter,
    Chocolate,
    Cinnamon,
}

public interface IInstructions
{
    public string Preparing();
}

public abstract class Ingredient : IInstructions
{
    public const int NumberOfIngredients = 4;
    public virtual string Name => "";
    public virtual IngredientsId Id { get; }

    public virtual string Preparing() => "";

}

public class Wheat : Ingredient
{
    public override string Name => "Wheat flour";

    public override IngredientsId Id => IngredientsId.Wheat;

    public override string Preparing() => "Sieve. Add to other ingredients";

}

public class Butter : Ingredient
{
    public override string Name => "Butter";

    public override IngredientsId Id => IngredientsId.Butter;

    public override string Preparing() => "Melt on low heat. Add to other ingredients";
}

public class Chocolate : Ingredient
{
    public override string Name => "Chocolate";

    public override IngredientsId Id => IngredientsId.Chocolate;

    public override string Preparing() => "Melt in a water bath. Add to other ingredients";
}

public class Cinnamon : Ingredient
{
    public override string Name => "Cinnamon";

    public override IngredientsId Id => IngredientsId.Cinnamon;

    public override string Preparing() => "Take half a teaspoon. Add to other ingredients";
}

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
            Console.WriteLine($"{(int)ingredient.Id+1}. {ingredient.Name}");
        }
    }
}
public class Recipe
{
    public readonly List<Ingredient> Ingredients;

    public Recipe(List<Ingredient> ingredientsList)
    {
        Ingredients = ingredientsList;
    }

    public static void CreateRecipe()
    {
        var ingredientsList = new List<Ingredient>();

        string userChoice;
        do
        {
            Console.WriteLine("Add an ingredient by it's Id or type anything else if finished.");
            userChoice = Console.ReadLine();

            switch (int.Parse(userChoice))
            {
                case (int)IngredientsId.Wheat:
                    ingredientsList.Add(new Wheat());
                    break;
                case (int)IngredientsId.Butter:
                    ingredientsList.Add(new Butter());
                    break;
                case (int)IngredientsId.Chocolate:
                    ingredientsList.Add(new Chocolate());
                    break;
                case (int)IngredientsId.Cinnamon:
                    ingredientsList.Add(new Cinnamon());
                    break;
            }
        } while (int.Parse(userChoice) < Ingredient.NumberOfIngredients);

        var newRecipe = new Recipe(ingredientsList);
    }
}

public static class Start
{
    public static void StartProgram()
    {
        Console.WriteLine("Create a new recipe! Available ingredients are: ");
        AllIngredients.PrintIngredients();
        Recipe.CreateRecipe();
    }
}