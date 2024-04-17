namespace NinjaOne_Api.Library.Types;

public class SoftwareProduct
{
    [JsonPropertyName(Property.Id)]
    public Guid? Id { get; internal set; }
    [JsonPropertyName(Property.VendorName)]
    public string? VendorName { get; internal set; }
    [JsonPropertyName(Property.ProductName)]
    public string? ProductName { get; internal set; }
    [JsonPropertyName(Property.Installable)]
    public bool? Installable { get; internal set; }
    [JsonPropertyName(Property.Active)]
    public bool? Active { get; internal set; }

    [JsonConstructor]
    internal SoftwareProduct(Guid? id, string? vendorName, string? productName, bool? installable, bool? active)
    {
        Id = id;
        VendorName = vendorName;
        ProductName = productName;
        Installable = installable;
        Active = active;
    }
}