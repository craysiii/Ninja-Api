namespace NinjaOne_Api.Library.Types;

public class Processor
{
    [JsonPropertyName(Property.Architecture)]
    public string? Architecture { get; internal set; }
    [JsonPropertyName(Property.MaxClockSpeed)]
    public long? MaxClockSpeed { get; internal set; }
    [JsonPropertyName(Property.ClockSpeed)]
    public long? ClockSpeed { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.CoreCount)]
    public int? CoreCount { get; internal set; }
    [JsonPropertyName(Property.LogicalCoreCount)]
    public int? LogicalCoreCount { get; internal set; }

    [JsonConstructor]
    internal Processor(
        string? architecture,
        long? maxClockSpeed,
        long? clockSpeed,
        string? name,
        int? coreCount,
        int? logicalCoreCount
    )
    {
        Architecture = architecture;
        MaxClockSpeed = maxClockSpeed;
        ClockSpeed = clockSpeed;
        Name = name;
        CoreCount = coreCount;
        LogicalCoreCount = logicalCoreCount;
    }
}