namespace NinjaOne_Api.Library.Types;

public class DeviceCustomFieldEndUserCustomization
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.Label)]
    public string? Label { get; set; }
}