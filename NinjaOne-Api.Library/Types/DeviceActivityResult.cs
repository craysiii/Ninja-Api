namespace NinjaOne_Api.Library.Types;

public class DeviceActivityResult
{
    [JsonPropertyName(Property.LastActivityId)]
    public long? LastActivityId { get; set; }
    [JsonPropertyName(Property.LastNodeActivityId)]
    public long? LastNodeActivityId { get; set; }
    [JsonPropertyName(Property.Activities)]
    public List<Activity>? Activities { get; set; }
}