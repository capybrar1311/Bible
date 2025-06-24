namespace BibleWithAPI;

public class Menu
{
    public static HttpClient client = new HttpClient();
    public static string? SetLanguage()
    {
        Console.Write("Enter language (\"ru\", \"en\")");

        string lang = Console.ReadLine();
        
        switch (lang)
        {
            case "ru":
                return "ru";
            case "en":
                return "en";
            case "exit":
                return "exit";
            default:
                return "ru";
        }
    }

    public static string? GetVerseNumber(string? language)
    {
        string? res = "john 3:16";
        switch (language)
        {
            case "en":
                Console.Write("Enter book and verse number ");
                res = Console.ReadLine();
                if (res == "") return "john 3:16";
                EnBibleManager.GetData(res).GetAwaiter().GetResult();
                break;
            case "ru":
                Console.Write("Введите книгу и номер стиха ");
                string input = Console.ReadLine();
                if (input == "") input = "Иоанн 3:16";
                RuBibleManager.GetData(input).GetAwaiter().GetResult();
                
                break;

        }

        return res;
    }
}