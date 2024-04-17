namespace NinjaOne_Api.Library.Types;

public class ScheduledTask
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.Enabled)]
    public bool? Enabled { get; internal set; }
    [JsonPropertyName(Property.Created)]
    public DateTime? Created { get; internal set; }
    [JsonPropertyName(Property.LastRun)]
    public DateTime? LastRun { get; internal set; }
    [JsonPropertyName(Property.RunCount)]
    public int? RunCount { get; internal set; }

    [JsonConstructor]
    internal ScheduledTask(
        string? name,
        int? id,
        string? description,
        bool? enabled,
        DateTime? created,
        DateTime? lastRun,
        int? runCount
    )
    {
        Name = name;
        Id = id;
        Description = description;
        Enabled = enabled;
        Created = created;
        LastRun = lastRun;
        RunCount = runCount;
    }
}