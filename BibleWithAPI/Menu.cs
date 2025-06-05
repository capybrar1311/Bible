namespace Bible;

public class Menu
{
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
                res = Console.ReadLine();
                if (res == "") return "john 3:16";
                break;
            case "ru":
                Console.Write("Введите книгу и номер стиха ");
                res = Console.ReadLine(); 
                if (res == "") return "john 3:16";
                break;
            
            
        }

        return res;
    }
}