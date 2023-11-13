namespace NinjaOne_Api.Library.Types;

public class DeviceCustomFieldValue
{
    [JsonPropertyName(Property.Id)]
    public Guid? Id { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.System)]
    public bool? System { get; set; }
    [JsonPropertyName(Property.Active)]
    public bool? Active { get; set; }
}