using System.Text.Json;

namespace BibleWithAPI;

public class RuChapter : List<RuBibleVerse>
{
    
    public static List<RuBibleVerse> chapter = new List<RuBibleVerse>();
    public int Number { get; set; }

    public void AddVerse(RuBibleVerse verse)
    {
        chapter.Add(verse);
    }
    
    
    
}