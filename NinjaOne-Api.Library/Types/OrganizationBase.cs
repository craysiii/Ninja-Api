namespace NinjaOne_Api.Library.Types;

public class OrganizationBase
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.NodeApprovalMode)]
    public NodeApprovalMode? NodeApprovalMode { get; set; }

    internal OrganizationBase()
    {
        
    }

    [JsonConstructor]
    internal OrganizationBase(int? id, string? name, string? description, NodeApprovalMode? nodeApprovalMode)
    {
        Id = id;
        Name = name;
        Description = description;
        NodeApprovalMode = nodeApprovalMode;
    }

    public OrganizationBase UpdateOrganizationDto()
    {
        return new OrganizationBase
        {
            Name = Name,
            Description = Description,
            NodeApprovalMode = NodeApprovalMode
        };
    }
}