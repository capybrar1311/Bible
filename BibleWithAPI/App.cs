using System.Text.Json;

namespace Bible;

using System;
using System.Net.Http;
using System.Threading.Tasks;

public class App
{
    
    
    
    public static async Task GetData(string userInput)
    {
        var client = new HttpClient();
        string requestUrl = $"https://bible-api.com/{userInput}?translation=web";
        var response = await client.GetStringAsync(requestUrl);
        var verse = JsonSerializer.Deserialize<BibleVerse>(response);
        PrintTheVerses(verse.Verses);
    }

    private static void PrintTheVerses(List<BibleVerse.Verse> vvv)
    {
        foreach (var ver in vvv)
        {
            Console.WriteLine($"{ver.BookName} {ver.Chapter}:{ver.VerseNumber} - {ver.Text?.Trim()}\n");
        }
    }
    
}