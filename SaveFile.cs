using System.Text.Json;
using CookiesCookbook;


public class SaveFile
{
    public static void Save(Recipe recipe)
    {
        switch (Settings.SaveOption)
        {
            case "Json":
                string recipeJson = JsonSerializer.Serialize(recipe);
                File.AppendAllText(Settings.FileName + ".json", $"\n{recipeJson}");
                break;
            case "Txt":
                string recipeTxt = recipe.ToString();
                File.AppendAllText(Settings.FileName + ".txt", $"\n{recipeTxt}");
                break;
        }
    }
}