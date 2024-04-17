namespace NinjaOne_Api.Library.Types;

public class DeviceQueryResult : DeviceBase
{
    [JsonPropertyName(Property.Score)]
    public int? Score { get; internal set; }
    [JsonPropertyName(Property.MatchAttribute)]
    public string? MatchAttribute { get; internal set; }
    [JsonPropertyName(Property.MatchAttributeValue)]
    public string? MatchAttributeValue { get; internal set; }

    [JsonConstructor]
    internal DeviceQueryResult(
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
        DeviceReferences? references,
        int? score,
        string? matchAttribute,
        string? matchAttributeValue
    ) : base(
        id,
        parentDeviceId,
        organizationId,
        locationId,
        nodeClass,
        nodeRoleId,
        rolePolicyId,
        policyId,
        approvalStatus,
        offline,
        displayName,
        systemName,
        dnsName,
        netBiosName,
        created,
        lastContact,
        lastUpdate,
        maintenance,
        references
    )
    {
        Score = score;
        MatchAttribute = matchAttribute;
        MatchAttributeValue = matchAttributeValue;
    }
}