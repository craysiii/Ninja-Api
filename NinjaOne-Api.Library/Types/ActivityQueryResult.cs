namespace NinjaOne_Api.Library.Types;

public class ActivityQueryResult
{
    [JsonPropertyName(Property.LastActivityId)]
    public long? LastActivityId { get; internal set; }
    [JsonPropertyName(Property.Activities)]
    public List<Activity>? Activities { get; internal set; }

    [JsonConstructor]
    internal ActivityQueryResult(long? lastActivityId, List<Activity>? activities)
    {
        LastActivityId = lastActivityId;
        Activities = activities;
    }
}