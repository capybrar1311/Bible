using Newtonsoft.Json;

namespace BibleWithAPI;

public class RuBible
{
    public Dictionary<string, string> Verses { get; set; }
    [JsonProperty("info")]
    public RuInfo Info { get; set; }

    public RuBible()
    {
        Verses = new Dictionary<string, string>();
        Info = new RuInfo();
    }
}