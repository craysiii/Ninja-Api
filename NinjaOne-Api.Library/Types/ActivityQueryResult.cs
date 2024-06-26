﻿namespace NinjaOne_Api.Library.Types;

public class ActivityQueryResult
{
    [JsonPropertyName(Property.LastActivityId)]
    public long? LastActivityId { get; set; }
    [JsonPropertyName(Property.Activities)]
    public List<Activity>? Activities { get; set; }
}