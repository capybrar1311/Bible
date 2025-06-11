

namespace BibleWithAPI;

public class RuBible
{
    public static List<string> allVerses = RuChapter.GetVerses("ffss");
    public static List<RuChapter> allChapters = RuChapter.MakeChapters(allVerses);
    public static List<RuBook> allBooks = RuBook.Makebooks(allChapters);
    
}

