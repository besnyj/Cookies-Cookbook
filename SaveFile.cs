using System.Text.Json;

public class SaveFile
{
    private const string FileName = "recipes.json";
    public static void Json(Recipe recipe)
    {
        string recipeJson = JsonSerializer.Serialize(recipe);
        File.AppendAllText(FileName, $"\n{recipeJson}");
    }

    public static void Txt(Recipe recipe)
    {
        string recipeTxt = recipe.ToString();
        File.AppendAllText(FileName, $"\n{recipeTxt}");
    }
}