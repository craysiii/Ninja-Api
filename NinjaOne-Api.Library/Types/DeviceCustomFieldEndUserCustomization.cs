namespace NinjaOne_Api.Library.Types;

public class DeviceCustomFieldEndUserCustomization
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.Label)]
    public string? Label { get; internal set; }

    [JsonConstructor]
    internal DeviceCustomFieldEndUserCustomization(string? name, string? description, string? label)
    {
        Name = name;
        Description = description;
        Label = label;
    }
}