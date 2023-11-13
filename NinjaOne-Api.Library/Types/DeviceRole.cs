namespace NinjaOne_Api.Library.Types;

public class DeviceRole
{
    [JsonPropertyName(Property.Id)]
    public int Id { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.NodeClass)]
    public NodeClass NodeClass { get; set; }
    [JsonPropertyName(Property.Custom)]
    public bool Custom { get; set; }
    [JsonPropertyName(Property.ChassisType)]
    public ChassisType ChassisType { get; set; }
    [JsonPropertyName(Property.Created)]
    public DateTime? Created { get; set; }
    [JsonPropertyName(Property.Tags)]
    public List<string>? Tags { get; set; }
    [JsonPropertyName(Property.Fields)]
    public JsonElement? Fields { get; set; }
}