using System.Text.Json;

namespace Bible;

public class RuChapter : RuBibleVerse
{
    private int lastIndex = 0;

    public List<RuBibleVerse> MakeChapter(List<RuBibleVerse> verses)
    {
        List<RuBibleVerse> chapter = new List<RuBibleVerse>();
        int check = verses[lastIndex].Chapter;
        for (int i = lastIndex; i < verses.Count; i++)
        {
            if (verses[i].Chapter == check)
            {
                chapter.Add(verses[i]);
            }
            else
            {
                lastIndex = i;
                
                chapter = new List<RuBibleVerse>();
            }
        }
        return chapter;
    }


}