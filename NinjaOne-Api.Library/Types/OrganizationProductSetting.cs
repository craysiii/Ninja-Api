namespace NinjaOne_Api.Library.Types;

public class OrganizationProductSetting
{
    [JsonPropertyName(Property.Product)]
    public string? Product { get; internal set; }
    [JsonPropertyName(Property.Enabled)]
    public bool? Enabled { get; internal set; }
    [JsonPropertyName(Property.Targets)]
    public List<string>? Targets { get; internal set; }
    [JsonPropertyName(Property.Options)]
    public JsonElement? Options { get; internal set; }

    [JsonConstructor]
    internal OrganizationProductSetting(string? product, bool? enabled, List<string>? targets, JsonElement? options)
    {
        Product = product;
        Enabled = enabled;
        Targets = targets;
        Options = options;
    }
}