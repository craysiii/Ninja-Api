namespace NinjaOne_Api.Library.Types;

public class Alert
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
    public JsonElement? Data { get; internal set; }
    [JsonPropertyName(Property.Device)]
    public DeviceBase? Device { get; internal set; }

    [JsonConstructor]
    internal Alert(
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
        JsonElement? data,
        DeviceBase? device
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
    }
}