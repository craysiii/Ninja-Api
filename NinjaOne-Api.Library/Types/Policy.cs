namespace NinjaOne_Api.Library.Types;

public class Policy
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.ParentPolicyId)]
    public int? ParentPolicyId { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.NodeClass)]
    public NodeClass? NodeClass { get; internal set; }
    [JsonPropertyName(Property.Updated)]
    public DateTime? Updated { get; internal set; }
    [JsonPropertyName(Property.NodeClassDefault)]
    public bool? NodeClassDefault { get; internal set; }

    [JsonConstructor]
    internal Policy(
        int? id,
        int? parentPolicyId,
        string? name,
        string? description,
        NodeClass? nodeClass,
        DateTime? updated,
        bool? nodeClassDefault
    )
    {
        Id = id;
        ParentPolicyId = parentPolicyId;
        Name = name;
        Description = description;
        NodeClass = nodeClass;
        Updated = updated;
        NodeClassDefault = nodeClassDefault;
    }
}