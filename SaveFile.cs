using System.Text.Json;

public class SaveFile
{
    private const string FileName = S;
    public static void Json(Recipe recipe)
    {
        string recipeJson = JsonSerializer.Serialize(recipe);
        File.AppendAllText(FileName, $"\n{recipeJson}");
    }

    public static void Txt(Recipe recipe)
    {
    }
}