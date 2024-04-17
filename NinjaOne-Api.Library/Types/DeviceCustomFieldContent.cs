namespace NinjaOne_Api.Library.Types;

public class DeviceCustomFieldContent
{
    [JsonPropertyName(Property.CustomizeForEndUser)]
    public bool? CustomizeForEndUser { get; internal set; }
    [JsonPropertyName(Property.EndUserCustomization)]
    public DeviceCustomFieldEndUserCustomization? EndUserCustomization { get; internal set; }
    [JsonPropertyName(Property.Values)]
    public List<DeviceCustomFieldValue>? Values { get; internal set; }
    [JsonPropertyName(Property.Required)]    
    public bool? Required { get; internal set; }
    [JsonPropertyName(Property.FooterText)]
    public string? FooterText { get; internal set; }
    [JsonPropertyName(Property.ToolTipText)]
    public string? ToolTipText { get; internal set; }
    [JsonPropertyName(Property.AdvancedSettings)]
    public JsonElement? AdvancedSettings { get; internal set; }

    [JsonConstructor]
    internal  DeviceCustomFieldContent(
        bool? customizeForEndUser,
        DeviceCustomFieldEndUserCustomization? endUserCustomization,
        List<DeviceCustomFieldValue>? values,
        bool? required,
        string? footerText,
        string? toolTipText,
        JsonElement? advancedSettings
    )
    {
        CustomizeForEndUser = customizeForEndUser;
        EndUserCustomization = endUserCustomization;
        Values = values;
        Required = required;
        FooterText = footerText;
        ToolTipText = toolTipText;
        AdvancedSettings = advancedSettings;
    }
}