namespace NinjaOne_Api.Library.Types;

public class DeviceRole
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.NodeClass)]
    public NodeClass? NodeClass { get; internal set; }
    [JsonPropertyName(Property.Custom)]
    public bool? Custom { get; internal set; }
    [JsonPropertyName(Property.ChassisType)]
    public ChassisType? ChassisType { get; internal set; }
    [JsonPropertyName(Property.Created)]
    public DateTime? Created { get; internal set; }

    [JsonConstructor]
    internal DeviceRole(
        int? id,
        string? name,
        string? description,
        NodeClass? nodeClass,
        bool? custom,
        ChassisType? chassisType,
        DateTime? created
    )
    {
        Id = id;
        Name = name;
        Description = description;
        NodeClass = nodeClass;
        Custom = custom;
        ChassisType = chassisType;
        Created = created;
    }
}