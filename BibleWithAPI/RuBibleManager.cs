using System.Text.Json;


namespace Bible;

public class RuBibleManager
{
    public static void Manager()
    {
        int book = Convert.ToInt32(Console.ReadLine());
        int chapter = Convert.ToInt32(Console.ReadLine());
        int verse = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(RuBible.allBooks[book][chapter][verse]);
    }
    
}