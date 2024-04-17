namespace NinjaOne_Api.Library.Types;

// TODO: Properly type DefaultGateway, DnsServers, and IPAddress properties after Ninja returns consistent values
public class DeviceNetworkInterface
{
    [JsonPropertyName(Property.AdapterName)]
    public string? AdapterName { get; internal set; }
    [JsonPropertyName(Property.DefaultGateway)]
    public JsonElement? DefaultGateways { get; internal set; }
    [JsonPropertyName(Property.InterfaceType)]
    public string? InterfaceType { get; internal set; }
    [JsonPropertyName(Property.DnsHostname)]
    public string? DnsHostname { get; internal set; }
    [JsonPropertyName(Property.DnsServers)]
    public JsonElement? DnsServers { get; internal set; }
    [JsonPropertyName(Property.InterfaceIndex)]
    public int? InterfaceIndex { get; internal set; }
    [JsonPropertyName(Property.InterfaceName)]
    public string? InterfaceName { get; internal set; }
    [JsonPropertyName(Property.IPAddress)]
    public JsonElement? IPAddresses { get; internal set; }
    [JsonPropertyName(Property.LinkSpeed)]
    public string? LinkSpeed { get; internal set; }
    [JsonPropertyName(Property.MacAddress)]
    public List<PhysicalAddress>? MacAddresses { get; internal set; }
    [JsonPropertyName(Property.Mtu)]
    public string? Mtu { get; internal set; }
    [JsonPropertyName(Property.Status)]
    public string? Status { get; internal set; }
    [JsonPropertyName(Property.SubnetMask)]
    public IPAddress? SubnetMask { get; internal set; }

    [JsonConstructor]
    internal DeviceNetworkInterface(
        string? adapterName,
        JsonElement? defaultGateways,
        string? interfaceType,
        string? dnsHostname,
        JsonElement? dnsServers,
        int? interfaceIndex,
        string? interfaceName,
        JsonElement? ipAddresses,
        string? linkSpeed,
        List<PhysicalAddress>? macAddresses,
        string? mtu,
        string? status,
        IPAddress? subnetMask
    )
    {
        AdapterName = adapterName;
        DefaultGateways = defaultGateways;
        InterfaceType = interfaceType;
        DnsHostname = dnsHostname;
        DnsServers = dnsServers;
        InterfaceIndex = interfaceIndex;
        InterfaceName = interfaceName;
        IPAddresses = ipAddresses;
        LinkSpeed = linkSpeed;
        MacAddresses = macAddresses;
        Mtu = mtu;
        Status = status;
        SubnetMask = subnetMask;
    }
}