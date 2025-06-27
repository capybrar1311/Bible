namespace BibleWithAPI;

public class Printer
{
    public void PrintTheVerses(RuBible response)
    {
        foreach (var verse in response.Verses)
        {
            Console.WriteLine($"{response.Info.Book} {response.Info.Chapter}:{verse.Key} {verse.Value}");
        }
    }
    
    private static void PrintTheVerses(List<EnBible.Verse> response)
    {
        foreach (var ver in response)
        {
            Console.WriteLine($"{ver.BookName} {ver.Chapter}:{ver.VerseNumber} - {ver.Text?.Trim()}\n");
        }
    }
    
}