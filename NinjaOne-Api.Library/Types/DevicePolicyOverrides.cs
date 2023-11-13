namespace NinjaOne_Api.Library.Types;

public class DevicePolicyOverrides
{
    [JsonPropertyName(Property.Overrides)]
    public IList<string>? Overrides { get; set; }
}