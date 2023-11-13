namespace NinjaOne_Api.Library.Types;

public class OrganizationPolicyAssignment
{
    [JsonPropertyName(Property.NodeRoleId)]
    public int? NodeRoleId { get; set; }
    [JsonPropertyName(Property.PolicyId)]
    public int? PolicyId { get; set; }
}