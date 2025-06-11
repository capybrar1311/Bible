

namespace BibleWithAPI;

public class RuBook : List<RuChapter>
{
    public List<RuChapter> book = new List<RuChapter>();
    public string Name { get; set; }
    public string Id { get; set; }
    
    public void AddVerse(RuBibleVerse verse)
    {
        RuChapter chapter = book.Find(c => c.Number == verse.Chapter);
        if (chapter == null)
        {
            chapter = new RuChapter { Number = verse.Chapter };
            book.Add(chapter);
        }
        chapter.AddVerse(verse);
    }
}