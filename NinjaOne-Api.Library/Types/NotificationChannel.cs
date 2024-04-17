namespace NinjaOne_Api.Library.Types;

public class NotificationChannel
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.Enabled)]
    public bool? Enabled { get; internal set; }
    [JsonPropertyName(Property.Type)]
    public NotificationChannelType? Type { get; internal set; }

    [JsonConstructor]
    internal NotificationChannel(int? id, string? name, string? description, bool? enabled, NotificationChannelType? type)
    {
        Id = id;
        Name = name;
        Description = description;
        Enabled = enabled;
        Type = type;
    }
}