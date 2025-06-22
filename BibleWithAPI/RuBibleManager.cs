using System.Text.Json;

namespace BibleWithAPI;

public class RuBibleManager
{
    

    public static async Task GetData(string userInput)
    {
        try
        {
            string requestUrl = $"https://justbible.ru/api/bible?translation=nasb&book=43&chapter=3&verses=16";
            
            var response = await Menu.client.GetStringAsync(requestUrl);

            var verse = ParseFullJson(response);
            PrintTheVerses(verse);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.ReadLine();
            throw;
        }
    }
    
    private static void PrintTheVerses(RuBible vvv)
    {
        Console.WriteLine(vvv.Info.Verse);
    }
    
    private static RuBible ParseFullJson(string json)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        return JsonSerializer.Deserialize<RuBible>(json, options);
    }
}