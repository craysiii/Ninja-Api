namespace NinjaOne_Api.Library.Types;

public class Processor
{
    [JsonPropertyName(Property.Architecture)]
    public string? Architecture { get; set; }
    [JsonPropertyName(Property.MaxClockSpeed)]
    public long MaxClockSpeed { get; set; }
    [JsonPropertyName(Property.ClockSpeed)]
    public long ClockSpeed { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.CoreCount)]
    public int CoreCount { get; set; }
    [JsonPropertyName(Property.LogicalCoreCount)]
    public int LogicalCoreCount { get; set; }
}