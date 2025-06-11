using System.Text.Json.Serialization;

namespace BibleWithAPI;

[JsonSerializable(typeof(EnBible))]
public partial class EnJsonContext : JsonSerializerContext;

[JsonSerializable(typeof(RuBibleVerse))]
public partial class RuJsonContext : JsonSerializerContext;
