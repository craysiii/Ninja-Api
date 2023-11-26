namespace NinjaOne_Api.Library.Types;

public class NetworkInterfaceQuery
{
    [JsonPropertyName(Property.Cursor)]
    public Cursor? Cursor { get; set; }
    [JsonPropertyName(Property.Results)]
    public IList<DeviceNetworkInterface>? Results { get; set; }
}