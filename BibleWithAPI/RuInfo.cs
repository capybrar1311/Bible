using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace BibleWithAPI;

public class RuInfo
{
    [JsonPropertyName("translation")]
    public string Translation { get; set; }
    [JsonPropertyName("book")]
    public string Book { get; set; }
    [JsonPropertyName("chapter")]
    public int Chapter { get; set; }
    [JsonPropertyName("verse")]
    public string Verse { get; set; }
}