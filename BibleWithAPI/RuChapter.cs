using System.Text.Json;

namespace Bible;

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
    
    public static List<RuBibleVerse> GetVerses(string book)
    {
        List<RuBibleVerse?> Verses = new List<RuBibleVerse?>();
        var json = File.ReadAllLines($"C:\\Users\\Lyamin_A_Admin\\RiderProjects\\Bible\\BibleWithAPI\\rst.json");
        foreach (var line in json)
        {
            Verses.Add(JsonSerializer.Deserialize<RuBibleVerse>(line, RuJsonContext.Default.RuBibleVerse));
        }

        return Verses;
    }
    
}