namespace Bible;

public class RuBook : RuChapter
{
    public string Name { get; set; }
    
    
    List<RuChapter> Book = Makebook(RuChapter.());
    public List<RuChapter> Makebook(List<RuChapter> chapters)
    {
        List<RuChapter> book = new List<RuChapter>();
        foreach (var chapter in chapters)
        {
            book.Add(chapter);
        }
        return book;
    }
}