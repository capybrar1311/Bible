namespace BibleWithAPI;

public class URLMaker
{
    private Dictionary<string, int> checkBookNumber =
        JSONManager.AllBooksDict(
            "C:\\Users\\lyami\\Learning\\ДЗ\\rider_projects\\BibleWithAPI\\BibleWithAPI\\bible_books.json");
    public string MakeRequestUrl(string[] forRequest)
    {
        string defaultUrl = $"https://justbible.ru/api/bible?translation=rst";
        
        if (!IsValidRequest(forRequest))
        {
            return defaultUrl;
        }

        switch (forRequest.Length)
        {
            case 1:
                return defaultUrl + "&book=" + checkBookNumber[forRequest[0]];
            case 2:
                return defaultUrl + "&book=" + checkBookNumber[forRequest[0]] + "&chapter=" + forRequest[1];
            case 3:
                return defaultUrl + "&book=" + checkBookNumber[forRequest[0]] + "&chapter=" + forRequest[1] + "&verse=" + forRequest[2];
        }
        return defaultUrl;
    }
    
    private bool IsValidRequest(string[] forRequest)
    {
        

        return checkBookNumber.ContainsKey(forRequest[0]);
    }
}