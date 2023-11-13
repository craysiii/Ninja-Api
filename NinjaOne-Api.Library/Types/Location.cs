namespace NinjaOne_Api.Library.Types;

public class Location
{
    [JsonPropertyName(Property.Id)]
    public int Id { get; set; }
    [JsonPropertyName(Property.OrganizationId)]
    public int? OrganizationId { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Address)]
    public string? Address { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.UserData)]
    public JsonElement? UserData { get; set; }
    [JsonPropertyName(Property.Tags)]
    public List<string>? Tags { get; set; }
    [JsonPropertyName(Property.Fields)]
    public JsonElement? Fields { get; set; }
}