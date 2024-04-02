namespace NinjaOne_Api.Library.Types;

public class OrganizationDocument
{
    [JsonPropertyName(Property.ClientDocumentId)]
    public int? ClientDocumentId { get; set; }
    [JsonPropertyName(Property.ClientDocumentName)]
    public string? ClientDocumentName { get; set; }
    [JsonPropertyName(Property.ClientDocumentDescription)]
    public string? ClientDocumentDescription { get; set; }
    [JsonPropertyName(Property.ClientDocumentUpdateTime)]
    public DateTime? ClientDocumentUpdateTime { get; set; }
    [JsonPropertyName(Property.AttributeValues)]
    public List<DocumentAttribute>? AttributeValues { get; set; }
}