namespace Bible;

public class RuBible
{
    public static List<RuBibleVerse> allVerses = RuChapter.GetVerses("ffss");
    public static List<RuChapter> allChapters = RuChapter.MakeChapters(allVerses);
    public static List<RuBook> allBooks {get; set; }
    
}

