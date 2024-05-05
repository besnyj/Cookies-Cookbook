using System.Text.Json;
using CookiesCookbook;

public class SaveFile
{
    private const string FileName = "recipes";

    public static void Save(Recipe recipe)
    {
        switch (Settings.SaveOption)
        {
            case "Txt":
                string recipeJson = JsonSerializer.Serialize(recipe);
                File.AppendAllText(FileName + ".json", $"\n{recipeJson}");
                break;
            case "Json":
                string recipeTxt = recipe.ToString();
                File.AppendAllText(FileName + ".txt", $"\n{recipeTxt}");
                break;
        }
    }
}