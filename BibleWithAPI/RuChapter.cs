using System.Text.Json;

namespace Bible;

public class RuChapter : List<RuBibleVerse>
{
    
    private static List<RuBibleVerse> chapter = new List<RuBibleVerse>();
    public string bookName = chapter[0].BookName;

    public void MakeChapter(List<RuBibleVerse> verses)
    {
        var currentChapter = new RuChapter();
        for (int i = 0; i < verses.Count-1; i++)
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
    }
    
}