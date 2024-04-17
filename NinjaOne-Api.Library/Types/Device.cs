namespace NinjaOne_Api.Library.Types;

public class Device : DeviceBase
{
    [JsonPropertyName(Property.IPAddresses)]
    public List<IPAddress>? IPAddresses { get; internal set; }
    [JsonPropertyName(Property.MacAddresses)]
    public List<PhysicalAddress>? MacAddresses { get; internal set; }
    [JsonPropertyName(Property.PublicIP)]
    public IPAddress? PublicIP { get; internal set; }
    [JsonPropertyName(Property.Notes)]
    public List<DeviceNote>? Notes { get; internal set; }
    [JsonPropertyName(Property.DeviceType)]
    public string? DeviceType { get; internal set; }

    [JsonConstructor]
    internal Device(
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
        List<IPAddress>? ipAddresses,
        List<PhysicalAddress>? macAddresses,
        IPAddress? publicIp,
        List<DeviceNote>? notes,
        string? deviceType
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
        IPAddresses = ipAddresses;
        MacAddresses = macAddresses;
        PublicIP = publicIp;
        Notes = notes;
        DeviceType = deviceType;
    }
}