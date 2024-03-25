namespace NinjaOne_Api.Library.Types;

public class DeviceVolume
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.DriveLetter)]
    public string? DriveLetter { get; set; }
    [JsonPropertyName(Property.DeviceType)]
    public string? DeviceType { get; set; }
    [JsonPropertyName(Property.FileSystem)]
    public string? FileSystem { get; set; }
    [JsonPropertyName(Property.AutoMount)]
    public bool? AutoMount { get; set; }
    [JsonPropertyName(Property.Compressed)]
    public bool? Compressed { get; set; }
    [JsonPropertyName(Property.Capacity)]
    public long? Capacity { get; set; }
    [JsonPropertyName(Property.FreeSpace)]
    public long? FreeSpace { get; set; }
    [JsonPropertyName(Property.SerialNumber)]
    public string? SerialNumber { get; set; }
    [JsonPropertyName(Property.BitLockerStatus)]
    public BitLockerStatus? BitLockerStatus { get; set; }
}