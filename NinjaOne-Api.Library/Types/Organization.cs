namespace NinjaOne_Api.Library.Types;

public class Organization : OrganizationBase
{
    [JsonPropertyName(Property.Locations)]
    public List<Location>? Locations { get; set; }
    [JsonPropertyName(Property.Policies)]
    public List<OrganizationPolicyAssignment>? Policies { get; set; }
    [JsonPropertyName(Property.Settings)]
    public OrganizationSettings? Settings { get; set; }
}