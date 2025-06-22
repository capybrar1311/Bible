namespace BibleWithAPI;

public class Menu
{
    public static HttpClient client = new HttpClient();
    public static string? SetLanguage()
    {
        Console.Write("Enter language (\"ru\", \"en\")");

        return Console.ReadLine();
    }

    public static string? GetVerseNumber(string? language)
    {
        string? res = "john 3:16";
        switch (language)
        {
            case "en":
                Console.Write("Enter book and verse number ");
                Console.ReadLine();
                if (res == "") return "john 3:16";
                APIManagerEn.GetData(res).GetAwaiter().GetResult();
                break;
            case "ru":
                Console.Write("Введите книгу и номер стиха ");
                
                RuBibleManager.GetData(Console.ReadLine()).GetAwaiter().GetResult();
                
                break;
        }

        return res;
    }
}