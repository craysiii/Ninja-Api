namespace NinjaOne_Api.Library.Types;

public class DevicePolicyOverrides
{
    [JsonPropertyName(Property.Overrides)]
    public List<string>? Overrides { get; set; }
}