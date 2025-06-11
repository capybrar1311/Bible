using System.Text.Json.Serialization;

namespace BibleWithAPI;


public class BibleMetadata
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("short_name")]
    public string ShortName { get; set; }
    
    [JsonPropertyName("module")]
    public string Module { get; set; }
    
    [JsonPropertyName("year")]
    public string Year { get; set; }
    
    [JsonPropertyName("publisher")]
    public string Publisher { get; set; }
    
    [JsonPropertyName("owner")]
    public string Owner { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    [JsonPropertyName("lang")]
    public string Lang { get; set; }
    
    [JsonPropertyName("lang_short")]
    public string LangShort { get; set; }
    
    [JsonPropertyName("copyright")]
    public int Copyright { get; set; }
    
    [JsonPropertyName("copyright_statement")]
    public string CopyrightStatement { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; }
    
    [JsonPropertyName("citation_limit")]
    public int CitationLimit { get; set; }
    
    [JsonPropertyName("restrict")]
    public int Restrict { get; set; }
    
    [JsonPropertyName("italics")]
    public int Italics { get; set; }
    
    [JsonPropertyName("strongs")]
    public int Strongs { get; set; }
    
    [JsonPropertyName("red_letter")]
    public int RedLetter { get; set; }
    
    [JsonPropertyName("paragraph")]
    public int Paragraph { get; set; }
    
    [JsonPropertyName("official")]
    public int Official { get; set; }
    
    [JsonPropertyName("research")]
    public int Research { get; set; }
    
    [JsonPropertyName("module_version")]
    public string ModuleVersion { get; set; }
}

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