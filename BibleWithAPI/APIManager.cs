namespace BibleWithAPI;

public class APIManager
{
    private static HttpClient _client = new HttpClient();

    public static async Task<string> GetData(string requestUrl)
    {
        var response = await _client.GetStringAsync(requestUrl);
        
        return response;
    }
}