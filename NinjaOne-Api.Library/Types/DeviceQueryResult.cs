namespace NinjaOne_Api.Library.Types;

public class DeviceQueryResult : DeviceBase
{
    [JsonPropertyName(Property.Score)]
    public int? Score { get; set; }
    [JsonPropertyName(Property.MatchAttribute)]
    public string? MatchAttribute { get; set; }
    [JsonPropertyName(Property.MatchAttributeValue)]
    public string? MatchAttributeValue { get; set; }
}