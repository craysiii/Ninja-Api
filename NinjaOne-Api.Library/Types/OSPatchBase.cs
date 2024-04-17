namespace NinjaOne_Api.Library.Types;

public class OSPatchBase
{
    [JsonPropertyName(Property.Id)]
    public Guid? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Severity)]
    public OSPatchSeverity? Severity { get; internal set; }
    [JsonPropertyName(Property.Type)]
    public OSPatchType? Type { get; internal set; }
    [JsonPropertyName(Property.InstalledAt)]
    public DateTime? InstalledAt { get; internal set; }
    [JsonPropertyName(Property.KBNumber)]
    public string? KBNumber { get; internal set; }

    [JsonConstructor]
    internal OSPatchBase(
        Guid? id,
        string? name,
        OSPatchSeverity? severity,
        OSPatchType? type,
        DateTime? installedAt,
        string? kbNumber
    )
    {
        Id = id;
        Name = name;
        Severity = severity;
        Type = type;
        InstalledAt = installedAt;
        KBNumber = kbNumber;
    }
}