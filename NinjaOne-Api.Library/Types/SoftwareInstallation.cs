namespace NinjaOne_Api.Library.Types;

public class SoftwareInstallation
{
    [JsonPropertyName(Property.InstallDate)]
    public string? InstallDate { get; set; }
    [JsonPropertyName(Property.Location)]
    public string? Location { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Publisher)]
    public string? Publisher { get; set; }
    [JsonPropertyName(Property.Size)]
    public long? Size { get; set; }
    [JsonPropertyName(Property.Version)]
    public string? Version { get; set; }
    [JsonPropertyName(Property.ProductCode)]
    public string? ProductCode { get; set; }
}