namespace NinjaOne_Api.Library.Types;

public class LocationBackupUsage : BackupUsageBase
{
    [JsonPropertyName(Property.LocationId)]
    public int LocationId { get; set; }
    [JsonPropertyName(Property.LocationName)]
    public string? LocationName { get; set; }
    [JsonPropertyName(Property.LocationDescription)]
    public string? LocationDescription { get; set; }
    [JsonPropertyName(Property.OrganizationId)]
    public int OrganizationId { get; set; }
    [JsonPropertyName(Property.OrganizationName)]
    public string? OrganizationName { get; set; }
}