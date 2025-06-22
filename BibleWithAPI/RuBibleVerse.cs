using System.Text.Json.Serialization;

namespace BibleWithAPI;


public class RuBibleVerse
{
    [JsonPropertyName("book_name")]
    public string BookName { get; set; }
    
    [JsonPropertyName("book")]
    public int Book { get; set; }
    
    [JsonPropertyName("chapter")]
    public int Chapter { get; set; }
    
    [JsonPropertyName("verse")]
    public int Verse { get; set; }
    
    [JsonPropertyName("text")]
    public string Text { get; set; }
}