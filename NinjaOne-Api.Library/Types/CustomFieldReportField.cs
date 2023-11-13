namespace NinjaOne_Api.Library.Types;

public class CustomFieldReportField
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Value)]
    public JsonObject? Value { get; set; }
    [JsonPropertyName(Property.UpdatedBy)]
    public CustomFieldUpdateSource? UpdatedBy { get; set; }
    [JsonPropertyName(Property.UpdateTime)]
    public DateTime? UpdateTime { get; set; }
}