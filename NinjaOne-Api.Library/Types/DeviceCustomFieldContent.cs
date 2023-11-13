namespace NinjaOne_Api.Library.Types;

public class DeviceCustomFieldContent
{
    [JsonPropertyName(Property.CustomizeForEndUser)]
    public bool? CustomizeForEndUser { get; set; }
    [JsonPropertyName(Property.EndUserCustomization)]
    public DeviceCustomFieldEndUserCustomization? EndUserCustomization { get; set; }
    [JsonPropertyName(Property.Values)]
    public IList<DeviceCustomFieldValue>? Values { get; set; }
    [JsonPropertyName(Property.Required)]    
    public bool? Required { get; set; }
    [JsonPropertyName(Property.FooterText)]
    public string? FooterText { get; set; }
    [JsonPropertyName(Property.ToolTipText)]
    public string? ToolTipText { get; set; }
    [JsonPropertyName(Property.AdvancedSettings)]
    public JsonElement? AdvancedSettings { get; set; }
}