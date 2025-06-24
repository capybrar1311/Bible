using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bible;

public class RuBibleVerse
{
    [JsonPropertyName("chapter")]
    public int Chapter { get; set; }
    
    [JsonPropertyName("verse")]
    public int Verse { get; set; }
    
    [JsonPropertyName("text")]
    public string Text { get; set; }
    
    [JsonPropertyName("translation_id")]
    public string TranslationId { get; set; }
    
    [JsonPropertyName("book_id")]
    public string BookId { get; set; }
    
    [JsonPropertyName("book_name")]
    public string BookName { get; set; }
    
    
}