namespace NinjaOne_Api.Library.Types;

public class Alert
{
    [JsonPropertyName(Property.Uid)]
    public Guid? Uid { get; set; }
    [JsonPropertyName(Property.DeviceId)]
    public int? DeviceId { get; set; }
    [JsonPropertyName(Property.Message)]
    public string? Message { get; set; }
    [JsonPropertyName(Property.CreateTime)]
    public DateTime? CreateTime { get; set; }
    [JsonPropertyName(Property.UpdateTime)]
    public DateTime? UpdateTime { get; set; }
    [JsonPropertyName(Property.SourceType)]
    public SourceType? SourceType { get; set; }
    [JsonPropertyName(Property.SourceConfigUid)]
    public Guid? SourceConfigUid { get; set; }
    [JsonPropertyName(Property.SourceName)]
    public string? SourceName { get; set; }
    [JsonPropertyName(Property.Subject)]
    public string? Subject { get; set; }
    [JsonPropertyName(Property.UserId)]
    public int? UserId { get; set; }
    [JsonPropertyName(Property.PsaTicketId)]
    public long? PsaTicketId { get; set; }
    [JsonPropertyName(Property.TicketTemplateId)]
    public int? TicketTemplateId { get; set; }
    [JsonPropertyName(Property.Data)]
    public JsonElement? Data { get; set; }
    [JsonPropertyName(Property.Device)]
    public DeviceBase? Device { get; set; }
}