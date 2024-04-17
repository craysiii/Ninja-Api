namespace NinjaOne_Api.Library.Types;

public class DocumentAttribute
{
    [JsonPropertyName(Property.AttributeName)]
    public string? AttributeName { get; internal set; }
    [JsonPropertyName(Property.ValueUpdateTime)]
    public DateTime? ValueUpdateTime { get; internal set; }
    [JsonPropertyName(Property.Value)]
    public JsonNode? Value { get; internal set; }

    [JsonConstructor]
    internal DocumentAttribute(
        string? attributeName,
        DateTime? valueUpdateTime,
        JsonNode? value
    )
    {
        AttributeName = attributeName;
        ValueUpdateTime = valueUpdateTime;
        Value = value;
    }
}