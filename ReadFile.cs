using System.Net;
using System.Text.Json;

namespace CookiesCookbook; 

public class ReadFile
{
    private const string _jsonPath = "/Users/felipe/Desktop/C#Projects/Cookies-Cookbook/bin/Debug/net8.0/recipes.json";
    private const string _txtPath = "/Users/felipe/Desktop/C#Projects/Cookies-Cookbook/bin/Debug/net8.0/recipes.txt";
    
    public static void ReadTxt()
    {
        string recipesTxt =
            File.ReadAllText(path: _txtPath);
        Console.WriteLine(recipesTxt);
    }

    public static void ReadJson()
    {
        if (File.Exists(_jsonPath))
        {
            var recipesJson = File.OpenRead(path: _jsonPath);
            Console.WriteLine(recipesJson.Length);
        }
        
    }
}