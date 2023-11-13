namespace NinjaOne_Api.Library.Types;

public class OrganizationBase
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.UserData)]
    public JsonElement? UserData { get; set; }
    [JsonPropertyName(Property.NodeApprovalMode)]
    public NodeApprovalMode NodeApprovalMode { get; set; }
    [JsonPropertyName(Property.Tags)]
    public List<string>? Tags { get; set; }
    [JsonPropertyName(Property.Fields)]
    public JsonElement? Fields { get; set; }
    [JsonPropertyName(Property.Id)]
    public int Id { get; set; }
}