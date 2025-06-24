using System.Text.Json;



namespace Bible;

public class APIManagerEn
{
    

    public static async Task GetData(string userInput)
    {
        try
        {
            string requestUrl = $"https://bible-api.com/{userInput}?translation=web";
            var response = await Menu.client.GetStringAsync(requestUrl);

            var verse = JsonSerializer.Deserialize<EnBible>(response, EnJsonContext.Default.EnBible);
            PrintTheVerses(verse.Verses);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.ReadLine();
            throw;
        }
    }
    
    private static void PrintTheVerses(List<EnBible.Verse> vvv)
    {
        foreach (var ver in vvv)
        {
            Console.WriteLine($"{ver.BookName} {ver.Chapter}:{ver.VerseNumber} - {ver.Text?.Trim()}\n");
        }
    }
}