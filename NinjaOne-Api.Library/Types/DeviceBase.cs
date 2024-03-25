namespace NinjaOne_Api.Library.Types;

public class DeviceBase
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; set; }
    [JsonPropertyName(Property.ParentDeviceId)]
    public int? ParentDeviceId { get; set; }
    [JsonPropertyName(Property.OrganizationId )]
    public int? OrganizationId { get; set; }
    [JsonPropertyName(Property.LocationId)]
    public int? LocationId { get; set; }
    [JsonPropertyName(Property.NodeClass)]
    public NodeClass? NodeClass { get; set; }
    [JsonPropertyName(Property.NodeRoleId)]
    public int? NodeRoleId { get; set; }
    [JsonPropertyName(Property.RolePolicyId)]
    public int? RolePolicyId { get; set; }
    [JsonPropertyName(Property.PolicyId)]
    public int? PolicyId { get; set; }
    [JsonPropertyName(Property.ApprovalStatus)]
    public ApprovalStatus? ApprovalStatus { get; set; }
    [JsonPropertyName(Property.Offline)]
    public bool? Offline { get; set; }
    [JsonPropertyName(Property.DisplayName)]
    public string? DisplayName { get; set; }
    [JsonPropertyName(Property.SystemName)]
    public string? SystemName { get; set; }
    [JsonPropertyName(Property.DnsName)]
    public string? DnsName { get; set; }
    [JsonPropertyName(Property.NetBiosName)]
    public string? NetBiosName { get; set; }
    [JsonPropertyName(Property.Created)]
    public DateTime? Created { get; set; }
    [JsonPropertyName(Property.LastContact)]
    public DateTime? LastContact { get; set; }
    [JsonPropertyName(Property.LastUpdate)]
    public DateTime? LastUpdate { get; set; }
    [JsonPropertyName(Property.UserData)]
    public JsonElement? UserData { get; set; }
    [JsonPropertyName(Property.Tags)]
    public List<string>? Tags { get; set; }
    [JsonPropertyName(Property.Fields)]
    public JsonElement? Fields { get; set; }
    [JsonPropertyName(Property.Maintenance)]
    public DeviceMaintenance? Maintenance { get; set; }
    [JsonPropertyName(Property.References)]
    public DeviceReferences? References { get; set; }

    public DeviceBase UpdateDeviceDto()
    {
        return new DeviceBase
        {
            DisplayName = DisplayName,
            NodeRoleId = NodeRoleId,
            PolicyId = PolicyId,
            UserData = UserData
        };
    }
}