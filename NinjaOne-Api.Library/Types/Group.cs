namespace NinjaOne_Api.Library.Types;

public class Group
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.Shared)]
    public bool? Shared { get; internal set; }
    [JsonPropertyName(Property.Created)]
    public DateTime? Created { get; internal set; }
    [JsonPropertyName(Property.Updated)]
    public DateTime? Updated { get; internal set; }
    [JsonPropertyName(Property.DeviceCount)]
    public int? DeviceCount { get; internal set; }
    [JsonPropertyName(Property.LastEvaluated)]
    public DateTime? LastEvaluated { get; internal set; }

    [JsonConstructor]
    internal Group(
        int? id,
        string? name,
        string? description,
        bool? shared,
        DateTime? created,
        DateTime? updated,
        int? deviceCount,
        DateTime? lastEvaluated
    )
    {
        Id = id;
        Name = name;
        Description = description;
        Shared = shared;
        Created = created;
        Updated = updated;
        DeviceCount = deviceCount;
        LastEvaluated = lastEvaluated;
    }
}