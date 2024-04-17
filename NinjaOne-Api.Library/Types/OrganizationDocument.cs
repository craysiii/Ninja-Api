namespace NinjaOne_Api.Library.Types;

public class OrganizationDocument
{
    [JsonPropertyName(Property.ClientDocumentId)]
    public int? ClientDocumentId { get; internal set; }
    [JsonPropertyName(Property.ClientDocumentName)]
    public string? ClientDocumentName { get; internal set; }
    [JsonPropertyName(Property.ClientDocumentDescription)]
    public string? ClientDocumentDescription { get; internal set; }
    [JsonPropertyName(Property.ClientDocumentUpdateTime)]
    public DateTime? ClientDocumentUpdateTime { get; internal set; }
    [JsonPropertyName(Property.AttributeValues)]
    public List<DocumentAttribute>? AttributeValues { get; internal set; }

    [JsonConstructor]
    internal OrganizationDocument(
        int? clientDocumentId,
        string? clientDocumentName,
        string? clientDocumentDescription,
        DateTime? clientDocumentUpdateTime,
        List<DocumentAttribute>? attributeValues
    )
    {
        ClientDocumentId = clientDocumentId;
        ClientDocumentName = clientDocumentName;
        ClientDocumentDescription = clientDocumentDescription;
        ClientDocumentUpdateTime = clientDocumentUpdateTime;
        AttributeValues = attributeValues;
    }
}