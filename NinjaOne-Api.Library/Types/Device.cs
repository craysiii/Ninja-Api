namespace NinjaOne_Api.Library.Types;

public class Device : DeviceBase
{
    [JsonPropertyName(Property.IPAddresses)]
    public IList<IPAddress>? IPAddresses { get; set; }
    [JsonPropertyName(Property.MacAddresses)]
    public IList<PhysicalAddress>? MacAddresses { get; set; }
    [JsonPropertyName(Property.PublicIP)]
    public IPAddress? PublicIP { get; set; }
    [JsonPropertyName(Property.Notes)]
    public IList<DeviceNote>? Notes { get; set; }
    [JsonPropertyName(Property.DeviceType)]
    public string? DeviceType { get; set; }
}