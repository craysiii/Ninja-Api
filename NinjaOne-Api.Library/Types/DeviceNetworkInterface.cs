namespace NinjaOne_Api.Library.Types;

// TODO: Ninja has inconsistent serialization of their defaultGateway, dnsServers, and ipAddress fields.
public class DeviceNetworkInterface
{
    [JsonPropertyName(Property.AdapterName)]
    public string? AdapterName { get; set; }
    [JsonPropertyName(Property.DefaultGateway)]
    public List<IPAddress>? DefaultGateways { get; set; }
    [JsonPropertyName(Property.InterfaceType)]
    public string? InterfaceType { get; set; }
    [JsonPropertyName(Property.DnsHostname)]
    public string? DnsHostname { get; set; }
    [JsonPropertyName(Property.DnsServers)]
    public List<IPAddress>? DnsServers { get; set; }
    [JsonPropertyName(Property.InterfaceIndex)]
    public int InterfaceIndex { get; set; }
    [JsonPropertyName(Property.InterfaceName)]
    public string? InterfaceName { get; set; }
    [JsonPropertyName(Property.IPAddress)]
    public List<IPAddress>? IPAddresses { get; set; }
    [JsonPropertyName(Property.LinkSpeed)]
    public string? LinkSpeed { get; set; }
    [JsonPropertyName(Property.MacAddress)]
    public List<PhysicalAddress>? MacAddresses { get; set; }
    [JsonPropertyName(Property.Mtu)]
    public string? Mtu { get; set; }
    [JsonPropertyName(Property.Status)]
    public string? Status { get; set; }
    [JsonPropertyName(Property.SubnetMask)]
    public IPAddress? SubnetMask { get; set; }
}