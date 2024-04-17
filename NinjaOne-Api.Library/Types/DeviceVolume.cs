namespace NinjaOne_Api.Library.Types;

public class DeviceVolume
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.DriveLetter)]
    public string? DriveLetter { get; internal set; }
    [JsonPropertyName(Property.DeviceType)]
    public string? DeviceType { get; internal set; }
    [JsonPropertyName(Property.FileSystem)]
    public string? FileSystem { get; internal set; }
    [JsonPropertyName(Property.AutoMount)]
    public bool? AutoMount { get; internal set; }
    [JsonPropertyName(Property.Compressed)]
    public bool? Compressed { get; internal set; }
    [JsonPropertyName(Property.Capacity)]
    public long? Capacity { get; internal set; }
    [JsonPropertyName(Property.FreeSpace)]
    public long? FreeSpace { get; internal set; }
    [JsonPropertyName(Property.SerialNumber)]
    public string? SerialNumber { get; internal set; }
    [JsonPropertyName(Property.BitLockerStatus)]
    public BitLockerStatus? BitLockerStatus { get; internal set; }

    [JsonConstructor]
    internal DeviceVolume(
        string? name,
        string? driveLetter,
        string? deviceType,
        string? fileSystem,
        bool? autoMount,
        bool? compressed,
        long? capacity,
        long? freeSpace,
        string? serialNumber,
        BitLockerStatus? bitLockerStatus
    )
    {
        Name = name;
        DriveLetter = driveLetter;
        DeviceType = deviceType;
        FileSystem = fileSystem;
        AutoMount = autoMount;
        Compressed = compressed;
        Capacity = capacity;
        FreeSpace = freeSpace;
        SerialNumber = serialNumber;
        BitLockerStatus = bitLockerStatus;
    }
}