namespace Bible;

using System.Collections.Generic;
using System.Text.Json.Serialization;

public class BibleVerse
{
    
    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    
    [JsonPropertyName("verses")]
    public List<Verse> Verses { get; set; } = new List<Verse>();

    
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    
    [JsonPropertyName("translation_id")]
    public string? TranslationId { get; set; }

    
    [JsonPropertyName("translation_name")]
    public string? TranslationName { get; set; }

    
    [JsonPropertyName("translation_note")]
    public string? TranslationNote { get; set; }

    public string ToString(int bbb)
    {
        return $"{Reference} - {Text?.Trim()}";
    }
    
    public class Verse
    {
        
        [JsonPropertyName("book_id")]
        public string? BookId { get; set; }

        
        [JsonPropertyName("book_name")]
        public string? BookName { get; set; }

        
        [JsonPropertyName("chapter")]
        public int Chapter { get; set; }

        
        [JsonPropertyName("verse")]
        public int VerseNumber { get; set; }

        
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        
        public override string ToString()
        {
            return $"{BookId} {Chapter}:{VerseNumber} - {Text?.Trim()}";
        }
    }

    
    
}