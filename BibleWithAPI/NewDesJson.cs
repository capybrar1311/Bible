using System.Text.Json.Serialization;

namespace Bible;

[JsonSerializable(typeof(BibleVerse))]
public partial class MyJsonContext : JsonSerializerContext;
