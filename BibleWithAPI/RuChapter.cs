using System.Text.Json;

namespace BibleWithAPI;

public class RuChapter : List<RuBibleVerse>
{
    
    public static List<RuBibleVerse> chapter = new List<RuBibleVerse>();
    public string bookName = chapter[0].BookName;

    public static List<RuChapter> MakeChapters(List<RuBibleVerse> verses)
    {
        var allchapt = new  List<RuChapter>();
        var currentChapter = new RuChapter();
        for (int i = 0; i < verses.Count; i++)
        {
            if (verses[i].Chapter == verses[i+1].Chapter)
            {
                currentChapter.Add(verses[i]);
            }
            else if (verses[i].Chapter != verses[i+1].Chapter)
            {
                RuBible.allChapters.Add(currentChapter);
                
                currentChapter = new RuChapter();
            }
        }
            
        return allchapt;
    }
    
    public static List<string> GetVerses(string book)
    {
        List<string?> Verses = new List<string?>();
        var json = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), $"rst.json"));
        if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), $"rst.json")))
        {
            Console.WriteLine("File not found");
        }
        foreach (var line in json)
        {
            Verses.Add(JsonSerializer.Deserialize<string>(line));
        }

        return Verses;
    }
    
}