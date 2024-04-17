namespace NinjaOne_Api.Library.Types;

public class Job
{
    [JsonPropertyName(Property.Uid)]
    public Guid? Uid { get; internal set; }
    [JsonPropertyName(Property.DeviceId)]
    public int? DeviceId { get; internal set; }
    [JsonPropertyName(Property.Message)]
    public string? Message { get; internal set; }
    [JsonPropertyName(Property.CreateTime)]
    public DateTime? CreateTime { get; internal set; }
    [JsonPropertyName(Property.UpdateTime)]
    public DateTime? UpdateTime { get; internal set; }
    [JsonPropertyName(Property.SourceType)]
    public SourceType? SourceType { get; internal set; }
    [JsonPropertyName(Property.SourceConfigUid)]
    public Guid? SourceConfigUid { get; internal set; }
    [JsonPropertyName(Property.SourceName)]
    public string? SourceName { get; internal set; }
    [JsonPropertyName(Property.Subject)]
    public string? Subject { get; internal set; }
    [JsonPropertyName(Property.UserId)]
    public int? UserId { get; internal set; }
    [JsonPropertyName(Property.PsaTicketId)]
    public long? PsaTicketId { get; internal set; }
    [JsonPropertyName(Property.TicketTemplateId)]
    public int? TicketTemplateId { get; internal set; }
    [JsonPropertyName(Property.Data)]
    public JsonObject? Data { get; internal set; }
    [JsonPropertyName(Property.Device)]
    public DeviceBase? Device { get; internal set; }
    [JsonPropertyName(Property.JobStatus)]
    public JobStatus? JobStatus { get; internal set; }
    [JsonPropertyName(Property.JobResult)]
    public JobResult? JobResult { get; internal set; }
    [JsonPropertyName(Property.JobType)]
    public JobType? JobType { get; internal set; }

    [JsonConstructor]
    internal Job(
        Guid? uid,
        int? deviceId,
        string? message,
        DateTime? createTime,
        DateTime? updateTime,
        SourceType? sourceType,
        Guid? sourceConfigUid,
        string? sourceName,
        string? subject,
        int? userId,
        long? psaTicketId,
        int? ticketTemplateId,
        JsonObject? data,
        DeviceBase? device,
        JobStatus? jobStatus,
        JobResult? jobResult,
        JobType? jobType
    )
    {
        Uid = uid;
        DeviceId = deviceId;
        Message = message;
        CreateTime = createTime;
        UpdateTime = updateTime;
        SourceType = sourceType;
        SourceConfigUid = sourceConfigUid;
        SourceName = sourceName;
        Subject = subject;
        UserId = userId;
        PsaTicketId = psaTicketId;
        TicketTemplateId = ticketTemplateId;
        Data = data;
        Device = device;
        JobStatus = jobStatus;
        JobResult = jobResult;
        JobType = jobType;
    }
}