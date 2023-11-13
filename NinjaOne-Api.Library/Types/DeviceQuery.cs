namespace NinjaOne_Api.Library.Types;

public class DeviceQuery
{
    [JsonPropertyName(Property.Query)]
    public string? Query { get; set; }
    [JsonPropertyName(Property.Devices)]
    public IList<DeviceQueryResult>? Devices { get; set; }
}