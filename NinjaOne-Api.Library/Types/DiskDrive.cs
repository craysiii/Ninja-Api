namespace NinjaOne_Api.Library.Types;

public class DiskDrive
{
    [JsonPropertyName(Property.BytesPerSector)]
    public int BytesPerSector { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.InterfaceType)]
    public string? InterfaceType { get; set; }
    [JsonPropertyName(Property.Manufacturer)]
    public string? Manufacturer { get; set; }
    [JsonPropertyName(Property.MediaType)]
    public string? MediaType { get; set; }
    [JsonPropertyName(Property.Model)]
    public string? Model { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.PartitionCount)]
    public int PartitionCount { get; set; }
    [JsonPropertyName(Property.SerialNumber)]
    public string? SerialNumber { get; set; }
    [JsonPropertyName(Property.Size)]
    public long Size { get; set; }
    [JsonPropertyName(Property.SmartCapable)]
    public bool SmartCapable { get; set; }
    [JsonPropertyName(Property.Status)]
    public string? Status { get; set; }
}