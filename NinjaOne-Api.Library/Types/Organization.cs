namespace NinjaOne_Api.Library.Types;

public class Organization : OrganizationBase
{
    [JsonPropertyName(Property.Locations)]
    public List<Location>? Locations { get; set; }
    [JsonPropertyName(Property.Policies)]
    public List<OrganizationPolicyAssignment>? Policies { get; set; }
    [JsonPropertyName(Property.Settings)]
    public OrganizationSettings? Settings { get; internal set; }

    public Organization()
    {
        
    }

    [JsonConstructor]
    internal Organization(
        int? id,
        string? name,
        string? description,
        NodeApprovalMode? nodeApprovalMode,
        List<Location>? locations,
        List<OrganizationPolicyAssignment>? policies,
        OrganizationSettings? settings
    ) : base(
        id,
        name,
        description,
        nodeApprovalMode
    )
    {
        Locations = locations;
        Policies = policies;
        Settings = settings;
    }
}