namespace NinjaOne_Api.Library.Types;

public class OrganizationProductSetting
{
    [JsonPropertyName(Property.Product)]
    public string? Product { get; set; }
    [JsonPropertyName(Property.Enabled)]
    public bool? Enabled { get; set; }
    [JsonPropertyName(Property.Targets)]
    public IList<string>? Targets { get; set; }
    [JsonPropertyName(Property.Options)]
    public JsonElement? Options { get; set; }
}