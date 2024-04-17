namespace NinjaOne_Api.Library.Types;

public class DeviceQuery
{
    [JsonPropertyName(Property.Query)]
    public string? Query { get; internal set; }
    [JsonPropertyName(Property.Devices)]
    public List<DeviceQueryResult>? Devices { get; internal set; }

    [JsonConstructor]
    internal DeviceQuery(string? query, List<DeviceQueryResult>? devices)
    {
        Query = query;
        Devices = devices;
    }
}