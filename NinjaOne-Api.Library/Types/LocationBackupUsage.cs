namespace NinjaOne_Api.Library.Types;

public class LocationBackupUsage : BackupUsageBase
{
    
    public int LocationId { get; set; }
    public string? LocationName { get; set; }
    public string? LocationDescription { get; set; }
    public int OrganizationId { get; set; }
    public string? OrganizationName { get; set; }
}