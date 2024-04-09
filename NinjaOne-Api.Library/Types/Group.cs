namespace NinjaOne_Api.Library.Types;

public class Group
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.Shared)]
    public bool? Shared { get; set; }
    [JsonPropertyName(Property.Created)]
    public DateTime? Created { get; set; }
    [JsonPropertyName(Property.Updated)]
    public DateTime? Updated { get; set; }
    [JsonPropertyName(Property.DeviceCount)]
    public int? DeviceCount { get; set; }
    [JsonPropertyName(Property.LastEvaluated)]
    public DateTime? LastEvaluated { get; set; }
}