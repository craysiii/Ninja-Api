namespace NinjaOne_Api.Library.Types;

public class SoftwarePatch
{
    [JsonPropertyName(Property.Id)]
    public Guid? Id { get; internal set; }
    [JsonPropertyName(Property.ProductIdentifier)]
    public Guid? ProductIdentifier { get; internal set; }
    [JsonPropertyName(Property.Title)]
    public string? Title { get; internal set; }
    [JsonPropertyName(Property.Impact)]
    public SoftwarePatchImpact? Impact { get; internal set; }
    [JsonPropertyName(Property.Status)]
    public string? Status { get; internal set; }
    [JsonPropertyName(Property.Type)]
    public string? Type { get; internal set; }
    [JsonPropertyName(Property.InstalledAt)]
    public DateTime? InstalledAt { get; internal set; }

    [JsonConstructor]
    internal SoftwarePatch(
        Guid? id,
        Guid? productIdentifier,
        string? title,
        SoftwarePatchImpact? impact,
        string? status,
        string? type,
        DateTime? installedAt
    )
    {
        Id = id;
        ProductIdentifier = productIdentifier;
        Title = title;
        Impact = impact;
        Status = status;
        Type = type;
        InstalledAt = installedAt;
    }
}