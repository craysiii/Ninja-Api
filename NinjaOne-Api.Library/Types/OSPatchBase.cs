namespace NinjaOne_Api.Library.Types;

public class OSPatchBase
{
    [JsonPropertyName(Property.Id)]
    public Guid? Id { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Severity)]
    public OSPatchSeverity? Severity { get; set; }
    [JsonPropertyName(Property.Type)]
    public OSPatchType? Type { get; set; }
    [JsonPropertyName(Property.InstalledAt)]
    public DateTime? InstalledAt { get; set; }
    [JsonPropertyName(Property.KBNumber)]
    public string? KBNumber { get; set; }
}