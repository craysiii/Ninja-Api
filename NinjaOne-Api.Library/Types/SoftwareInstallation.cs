namespace NinjaOne_Api.Library.Types;

public class SoftwareInstallation
{
    [JsonPropertyName(Property.InstallDate)]
    public string? InstallDate { get; internal set; }
    [JsonPropertyName(Property.Location)]
    public string? Location { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Publisher)]
    public string? Publisher { get; internal set; }
    [JsonPropertyName(Property.Size)]
    public long? Size { get; internal set; }
    [JsonPropertyName(Property.Version)]
    public string? Version { get; internal set; }
    [JsonPropertyName(Property.ProductCode)]
    public string? ProductCode { get; internal set; }

    [JsonConstructor]
    internal SoftwareInstallation(
        string? installDate,
        string? location,
        string? name,
        string? publisher,
        long? size,
        string? version,
        string? productCode
    )
    {
        InstallDate = installDate;
        Location = location;
        Name = name;
        Publisher = publisher;
        Size = size;
        Version = version;
        ProductCode = productCode;
    }
}