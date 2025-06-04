using System.Text.Json;


namespace Bible;

public class App
{
    
    
    
    public static async Task GetData(string userInput)
    {
            var client = new HttpClient();
        try
        {
            string requestUrl = $"https://bible-api.com/{userInput}?translation=web";
            var response = await client.GetStringAsync(requestUrl);
        
            var verse = JsonSerializer.Deserialize<BibleVerse>(response, MyJsonContext.Default.BibleVerse);
            PrintTheVerses(verse.Verses);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.ReadLine();
            throw;
        }
        
        
    }

    private static void PrintTheVerses(List<BibleVerse.Verse> vvv)
    {
        foreach (var ver in vvv)
        {
            Console.WriteLine($"{ver.BookName} {ver.Chapter}:{ver.VerseNumber} - {ver.Text?.Trim()}\n");
        }
    }
    
}