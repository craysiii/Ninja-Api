namespace NinjaOne_Api.Library.Types;

public class DeviceCustomFieldValue
{
    [JsonPropertyName(Property.Id)]
    public Guid? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.System)]
    public bool? System { get; internal set; }
    [JsonPropertyName(Property.Active)]
    public bool? Active { get; internal set; }

    [JsonConstructor]
    internal DeviceCustomFieldValue(Guid? id, string? name, bool? system, bool? active)
    {
        Id = id;
        Name = name;
        System = system;
        Active = active;
    }
}