namespace NinjaOne_Api.Library.Types;

public class OrganizationBase
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.NodeApprovalMode)]
    public NodeApprovalMode? NodeApprovalMode { get; set; }
    [JsonPropertyName(Property.Id)]
    public int? Id { get; init; }

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