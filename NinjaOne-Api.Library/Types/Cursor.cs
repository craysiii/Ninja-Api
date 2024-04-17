namespace NinjaOne_Api.Library.Types;

public class Cursor
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Offset)]
    public int? Offset { get; internal set; }
    [JsonPropertyName(Property.Count)]
    public int? Count { get; internal set; }
    [JsonPropertyName(Property.Expires)]
    public DateTime? Expires { get; internal set; }

    [JsonConstructor]
    internal Cursor(string? name, int? offset, int? count, DateTime? expires)
    {
        Name = name;
        Offset = offset;
        Count = count;
        Expires = expires;
    }
}