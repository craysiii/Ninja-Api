namespace NinjaOne_Api.Library.Types;

public class Device : DeviceBase
{
    [JsonPropertyName(Property.IPAddresses)]
    public List<IPAddress>? IPAddresses { get; set; }
    [JsonPropertyName(Property.MacAddresses)]
    public List<PhysicalAddress>? MacAddresses { get; set; }
    [JsonPropertyName(Property.PublicIP)]
    public IPAddress? PublicIP { get; set; }
    [JsonPropertyName(Property.Notes)]
    public List<DeviceNote>? Notes { get; set; }
    [JsonPropertyName(Property.DeviceType)]
    public string? DeviceType { get; set; }
}