namespace NinjaOne_Api.Library.Types;

public class DocumentAttribute
{
    [JsonPropertyName(Property.AttributeName)]
    public string? AttributeName { get; set; }
    [JsonPropertyName(Property.ValueUpdateTime)]
    public DateTime? ValueUpdateTime { get; set; }
    [JsonPropertyName(Property.Value)]
    public JsonNode? Value { get; set; }
}