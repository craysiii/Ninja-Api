namespace NinjaOne_Api.Library.Types;

public class SoftwarePatch
{
    [JsonPropertyName(Property.Id)]
    public Guid? Id { get; set; }
    [JsonPropertyName(Property.ProductIdentifier)]
    public Guid? ProductIdentifier { get; set; }
    [JsonPropertyName(Property.Title)]
    public string? Title { get; set; }
    [JsonPropertyName(Property.Impact)]
    public SoftwarePatchImpact? Impact { get; set; }
    [JsonPropertyName(Property.Status)]
    public string? Status { get; set; }
    [JsonPropertyName(Property.Type)]
    public string? Type { get; set; }
    [JsonPropertyName(Property.InstalledAt)]
    public DateTime? InstalledAt { get; set; }
}