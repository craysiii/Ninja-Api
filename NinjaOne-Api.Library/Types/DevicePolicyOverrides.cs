namespace NinjaOne_Api.Library.Types;

public class DevicePolicyOverrides
{
    [JsonPropertyName(Property.Overrides)]
    public List<string>? Overrides { get; internal set; }

    [JsonConstructor]
    internal DevicePolicyOverrides(List<string>? overrides)
    {
        Overrides = overrides;
    }
}