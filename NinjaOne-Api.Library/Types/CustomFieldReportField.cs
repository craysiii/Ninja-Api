namespace NinjaOne_Api.Library.Types;

public class CustomFieldReportField
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Value)]
    public JsonElement? Value { get; internal set; }
    [JsonPropertyName(Property.UpdatedBy)]
    public CustomFieldUpdateSource? UpdatedBy { get; internal set; }
    [JsonPropertyName(Property.UpdateTime)]
    public DateTime? UpdateTime { get; internal set; }

    [JsonConstructor]
    internal CustomFieldReportField(
        string? name,
        JsonElement? value,
        CustomFieldUpdateSource? updatedBy,
        DateTime? updateTime
    )
    {
        Name = name;
        Value = value;
        UpdatedBy = updatedBy;
        UpdateTime = updateTime;
    }
}