namespace NinjaOne_Api.Library.Types;

public class ScheduledTask
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Id)]
    public int? Id { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.Enabled)]
    public bool? Enabled { get; set; }
    [JsonPropertyName(Property.Created)]
    public DateTime? Created { get; set; }
    [JsonPropertyName(Property.LastRun)]
    public DateTime? LastRun { get; set; }
    [JsonPropertyName(Property.RunCount)]
    public int? RunCount { get; set; }
}