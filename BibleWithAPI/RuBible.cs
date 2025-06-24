using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BibleWithAPI;

public class RuBible
{
    [Newtonsoft.Json.JsonExtensionData]
    public required Dictionary<string, JToken> Verses { get; set; }
    [JsonProperty("info")]
    public required RuInfo Info { get; set; }
}

public class RuInfo
{
    [JsonPropertyName("translation")]
    public required string Translation { get; set; }

    [JsonPropertyName("book")]
    public required string Book { get; set; }

    [JsonPropertyName("chapter")]
    public int Chapter { get; set; }

    [JsonPropertyName("verse")]
    public required string Verse { get; set; }
}

