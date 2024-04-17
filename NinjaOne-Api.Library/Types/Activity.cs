namespace NinjaOne_Api.Library.Types;

public class Activity
{
    [JsonPropertyName(Property.Id)]
    public long? Id { get; internal set; }
    [JsonPropertyName(Property.ActivityTime)]
    public DateTime? ActivityTime { get; internal set; }
    [JsonPropertyName(Property.DeviceId)]
    public int? DeviceId { get; internal set; }
    [JsonPropertyName(Property.Severity)]
    public Severity? Severity { get; internal set; }
    [JsonPropertyName(Property.Priority)]
    public Priority? Priority { get; internal set; }
    [JsonPropertyName(Property.SeriesUid)]
    public Guid? SeriesUid { get; internal set; }
    [JsonPropertyName(Property.ActivityType)]
    public ActivityType? ActivityType { get; internal set; }
    [JsonPropertyName(Property.StatusCode)]
    public StatusCode? StatusCode { get; internal set; }
    [JsonPropertyName(Property.Status)]
    public string? Status { get; internal set; }
    [JsonPropertyName(Property.ActivityResult)]
    public ActivityResult? ActivityResult { get; internal set; }
    [JsonPropertyName(Property.SourceConfigUid)]
    public Guid? SourceConfigUid { get; internal set; }
    [JsonPropertyName(Property.SourceName)]
    public string? SourceName { get; internal set; }
    [JsonPropertyName(Property.Subject)]
    public string? Subject { get; internal set; }
    [JsonPropertyName(Property.UserId)]
    public int? UserId { get; internal set; }
    [JsonPropertyName(Property.Message)]
    public string? Message { get; internal set; }
    [JsonPropertyName(Property.Type)]
    public string? Type { get; internal set; }
    [JsonPropertyName(Property.Data)]
    public JsonObject? Data { get; internal set; }

    [JsonConstructor]
    internal Activity(
        long? id,
        DateTime? activityTime,
        int? deviceId,
        Severity? severity,
        Priority? priority,
        Guid? seriesUid,
        ActivityType? activityType,
        StatusCode? statusCode,
        string? status,
        ActivityResult? activityResult,
        Guid? sourceConfigUid,
        string? sourceName,
        string? subject,
        int? userId,
        string? message,
        string? type,
        JsonObject? data
    )
    {
        Id = id;
        ActivityTime = activityTime;
        DeviceId = deviceId;
        Severity = severity;
        Priority = priority;
        SeriesUid = seriesUid;
        ActivityType = activityType;
        StatusCode = statusCode;
        Status = status;
        ActivityResult = activityResult;
        SourceConfigUid = sourceConfigUid;
        SourceName = sourceName;
        Subject = subject;
        UserId = userId;
        Message = message;
        Type = type;
        Data = data;
    }
}