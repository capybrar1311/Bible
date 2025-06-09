namespace Bible;

public class RuBook : List<RuChapter>
{
    public static List<RuChapter> book = new List<RuChapter>();
    public string bookName =  book[0].bookName;
    
    
    public void Makebook(List<RuChapter> chapters)
    {
        RuBook currentBook = new RuBook();
        for (int i = 0; i < chapters.Count-1; i++)
        {
            if (chapters[i].bookName == chapters[i+1].bookName)
            {
                book.Add(chapters[i]);
            }
            else if (chapters[i].bookName != chapters[i+1].bookName)
            {
                RuBook.book.Add(chapters[i]);
                RuBible.allBooks.Add(currentBook);
                currentBook = new RuBook();
            }
        }
       
    }
}