namespace NinjaOne_Api.Library.Types;

public class DeviceBase
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.ParentDeviceId)]
    public int? ParentDeviceId { get; internal set; }
    [JsonPropertyName(Property.OrganizationId )]
    public int? OrganizationId { get; internal set; }
    [JsonPropertyName(Property.LocationId)]
    public int? LocationId { get; internal set; }
    [JsonPropertyName(Property.NodeClass)]
    public NodeClass? NodeClass { get; internal set; }
    [JsonPropertyName(Property.NodeRoleId)]
    public int? NodeRoleId { get; set; }
    [JsonPropertyName(Property.RolePolicyId)]
    public int? RolePolicyId { get; internal set; }
    [JsonPropertyName(Property.PolicyId)]
    public int? PolicyId { get; set; }
    [JsonPropertyName(Property.ApprovalStatus)]
    public ApprovalStatus? ApprovalStatus { get; internal set; }
    [JsonPropertyName(Property.Offline)]
    public bool? Offline { get; internal set; }
    [JsonPropertyName(Property.DisplayName)]
    public string? DisplayName { get; set; }
    [JsonPropertyName(Property.SystemName)]
    public string? SystemName { get; internal set; }
    [JsonPropertyName(Property.DnsName)]
    public string? DnsName { get; internal set; }
    [JsonPropertyName(Property.NetBiosName)]
    public string? NetBiosName { get; internal set; }
    [JsonPropertyName(Property.Created)]
    public DateTime? Created { get; internal set; }
    [JsonPropertyName(Property.LastContact)]
    public DateTime? LastContact { get; internal set; }
    [JsonPropertyName(Property.LastUpdate)]
    public DateTime? LastUpdate { get; internal set; }
    [JsonPropertyName(Property.Maintenance)]
    public DeviceMaintenance? Maintenance { get; internal set; }
    [JsonPropertyName(Property.References)]
    public DeviceReferences? References { get; internal set; }

    internal DeviceBase()
    {
        
    }

    [JsonConstructor]
    internal DeviceBase(
        int? id,
        int? parentDeviceId,
        int? organizationId,
        int? locationId,
        NodeClass? nodeClass,
        int? nodeRoleId,
        int? rolePolicyId,
        int? policyId,
        ApprovalStatus? approvalStatus,
        bool? offline,
        string? displayName,
        string? systemName,
        string? dnsName,
        string? netBiosName,
        DateTime? created,
        DateTime? lastContact,
        DateTime? lastUpdate,
        DeviceMaintenance? maintenance,
        DeviceReferences? references
    )
    {
        Id = id;
        ParentDeviceId = parentDeviceId;
        OrganizationId = organizationId;
        LocationId = locationId;
        NodeClass = nodeClass;
        NodeRoleId = nodeRoleId;
        RolePolicyId = rolePolicyId;
        PolicyId = policyId;
        ApprovalStatus = approvalStatus;
        Offline = offline;
        DisplayName = displayName;
        SystemName = systemName;
        DnsName = dnsName;
        NetBiosName = netBiosName;
        Created = created;
        LastContact = lastContact;
        LastUpdate = lastUpdate;
        Maintenance = maintenance;
        References = references;
    }

    public DeviceBase UpdateDeviceDto()
    {
        return new DeviceBase
        {
            DisplayName = DisplayName,
            NodeRoleId = NodeRoleId,
            PolicyId = PolicyId
        };
    }
}