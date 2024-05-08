using System.Net;

namespace CookiesCookbook; 

public class ReadFile
{
    public static void ReadTxt()
    {
        string recipesTxt =
            File.ReadAllText(path:"/Users/felipe/Desktop/C#Projects/Cookies-Cookbook/bin/Debug/net8.0/recipes.txt");
        Console.WriteLine(recipesTxt);
    }

    public static void ReadJson()
    {
        
    }
}