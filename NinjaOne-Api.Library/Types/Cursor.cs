namespace NinjaOne_Api.Library.Types;

public class Cursor
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Offset)]
    public int? Offset { get; set; }
    [JsonPropertyName(Property.Count)]
    public int? Count { get; set; }
    [JsonPropertyName(Property.Expires)]
    public DateTime? Expires { get; set; }
}