namespace BibleWithAPI;
using Newtonsoft.Json;
public class RuBibleManager
{
    public static void ManageTheVerses()
    {
        //List<string?> Verses = new List<string?>();
        var json = File.ReadAllText("rst.json");
        if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), $"synodal.json")))
        {
            Console.WriteLine("File not found");
        }
        RuBibleVerse[] allVerses = JsonConvert.DeserializeObject<RuBibleVerse[]>(json);

        List<RuBook> Bible = new List<RuBook>();
        foreach (RuBibleVerse verse in allVerses)
        {
            RuBook book = Bible.Find(b => b.Id == verse.BookName);
            if (book.Name == null)
            {
                book = new RuBook { Id = verse.BookName, Name = verse.BookName };
                Bible.Add(book);
            }
            
            book.AddVerse(verse);
        }
        Console.WriteLine($"Загружено книг: {Bible.Count}");
        Console.WriteLine($"Например, в книге 'Genesis' глав: {Bible[0].book.Count}");
    }
    
}