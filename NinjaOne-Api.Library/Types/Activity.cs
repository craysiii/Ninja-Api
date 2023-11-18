namespace NinjaOne_Api.Library.Types;

public class Activity
{
    [JsonPropertyName(Property.Id)]
    public long Id { get; set; }
    [JsonPropertyName(Property.ActivityTime)]
    public DateTime ActivityTime { get; set; }
    [JsonPropertyName(Property.DeviceId)]
    public int DeviceId { get; set; }
    [JsonPropertyName(Property.Severity)]
    public Severity? Severity { get; set; }
    [JsonPropertyName(Property.Priority)]
    public Priority? Priority { get; set; }
    [JsonPropertyName(Property.SeriesUid)]
    public Guid? SeriesUid { get; set; }
    [JsonPropertyName(Property.ActivityType)]
    public ActivityType ActivityType { get; set; }
    [JsonPropertyName(Property.StatusCode)]
    public StatusCode StatusCode { get; set; }
    [JsonPropertyName(Property.Status)]
    public string? Status { get; set; }
    [JsonPropertyName(Property.ActivityResult)]
    public ActivityResult? ActivityResult { get; set; }
    [JsonPropertyName(Property.SourceConfigUid)]
    public Guid? SourceConfigUid { get; set; }
    [JsonPropertyName(Property.SourceName)]
    public string? SourceName { get; set; }
    [JsonPropertyName(Property.Subject)]
    public string? Subject { get; set; }
    [JsonPropertyName(Property.UserId)]
    public int? UserId { get; set; }
    [JsonPropertyName(Property.Message)]
    public string? Message { get; set; }
    [JsonPropertyName(Property.Type)]
    public string? Type { get; set; }
    [JsonPropertyName(Property.Data)]
    public JsonObject? Data { get; set; }
}