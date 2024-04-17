namespace NinjaOne_Api.Library.Types;

public class DiskDrive
{
    [JsonPropertyName(Property.BytesPerSector)]
    public int? BytesPerSector { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.InterfaceType)]
    public string? InterfaceType { get; internal set; }
    [JsonPropertyName(Property.Manufacturer)]
    public string? Manufacturer { get; internal set; }
    [JsonPropertyName(Property.MediaType)]
    public string? MediaType { get; internal set; }
    [JsonPropertyName(Property.Model)]
    public string? Model { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.PartitionCount)]
    public int? PartitionCount { get; internal set; }
    [JsonPropertyName(Property.SerialNumber)]
    public string? SerialNumber { get; internal set; }
    [JsonPropertyName(Property.Size)]
    public long? Size { get; internal set; }
    [JsonPropertyName(Property.SmartCapable)]
    public bool? SmartCapable { get; internal set; }
    [JsonPropertyName(Property.Status)]
    public string? Status { get; internal set; }

    [JsonConstructor]
    internal DiskDrive(
        int? bytesPerSector,
        string? description,
        string? interfaceType,
        string? manufacturer,
        string? mediaType,
        string? model,
        string? name,
        int? partitionCount,
        string? serialNumber,
        long? size,
        bool? smartCapable,
        string? status
    )
    {
        BytesPerSector = bytesPerSector;
        Description = description;
        InterfaceType = interfaceType;
        Manufacturer = manufacturer;
        MediaType = mediaType;
        Model = model;
        Name = name;
        PartitionCount = partitionCount;
        SerialNumber = serialNumber;
        Size = size;
        SmartCapable = smartCapable;
        Status = status;
    }
}