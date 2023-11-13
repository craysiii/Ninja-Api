namespace NinjaOne_Api.Library.Types;

public class SoftwareProduct
{
    [JsonPropertyName(Property.Id)]
    public Guid? Id { get; set; }
    [JsonPropertyName(Property.VendorName)]
    public string? VendorName { get; set; }
    [JsonPropertyName(Property.ProductName)]
    public string? ProductName { get; set; }
    [JsonPropertyName(Property.Installable)]
    public bool? Installable { get; set; }
    [JsonPropertyName(Property.Active)]
    public bool? Active { get; set; }
}