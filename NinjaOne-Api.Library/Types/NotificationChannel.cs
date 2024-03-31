namespace NinjaOne_Api.Library.Types;

public class NotificationChannel
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.Enabled)]
    public bool? Enabled { get; set; }
    [JsonPropertyName(Property.Type)]
    public NotificationChannelType? Type { get; set; }
}