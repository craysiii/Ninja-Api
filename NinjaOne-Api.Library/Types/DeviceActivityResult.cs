namespace NinjaOne_Api.Library.Types;

public class DeviceActivityResult
{
    [JsonPropertyName(Property.LastActivityId)]
    public long? LastActivityId { get; internal set; }
    [JsonPropertyName(Property.LastNodeActivityId)]
    public long? LastNodeActivityId { get; internal set; }
    [JsonPropertyName(Property.Activities)]
    public List<Activity>? Activities { get; internal set; }

    [JsonConstructor]
    internal DeviceActivityResult(long? lastActivityId, long? lastNodeActivityId, List<Activity>? activities)
    {
        LastActivityId = lastActivityId;
        LastNodeActivityId = lastNodeActivityId;
        Activities = activities;
    }
}