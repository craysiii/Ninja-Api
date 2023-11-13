namespace NinjaOne_Api.Library.Types;

public class DocumentUpdate
{
    [JsonPropertyName(Property.DocumentName)]
    public string? DocumentName { get; set; }
    [JsonPropertyName(Property.DocumentDescription)]
    public string? DocumentDescription { get; set; }
    [JsonPropertyName(Property.ClientDocumentName)]
    public string? ClientDocumentName { get; set; }
    [JsonPropertyName(Property.ClientDocumentDescription)]
    public string? ClientDocumentDescription { get; set; }
    [JsonPropertyName(Property.Fields)]
    public Dictionary<string, string?>? Fields { get; set; }
    [JsonPropertyName(Property.AttributeValues)]
    public Dictionary<string, string?>? AttributeValues { get; set; }
}