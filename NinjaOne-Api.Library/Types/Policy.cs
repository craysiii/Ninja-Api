namespace NinjaOne_Api.Library.Types;

public class Policy
{
    [JsonPropertyName(Property.Id)]
    public int Id { get; set; }
    [JsonPropertyName(Property.ParentPolicyId)]
    public int ParentPolicyId { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.NodeClass)]
    public NodeClass NodeClass { get; set; }
    [JsonPropertyName(Property.Updated)]
    public DateTime? Updated { get; set; }
    [JsonPropertyName(Property.NodeClassDefault)]
    public bool NodeClassDefault { get; set; }
    [JsonPropertyName(Property.Tags)]
    public List<string>? Tags { get; set; }
    [JsonPropertyName(Property.Fields)]
    public JsonElement? Fields { get; set; }
}