namespace NinjaOne_Api.Library.Types;

public class LocationBackupUsage : BackupUsageBase
{
    [JsonPropertyName(Property.LocationId)]
    public int? LocationId { get; internal set; }
    [JsonPropertyName(Property.LocationName)]
    public string? LocationName { get; internal set; }
    [JsonPropertyName(Property.LocationDescription)]
    public string? LocationDescription { get; internal set; }
    [JsonPropertyName(Property.OrganizationId)]
    public int? OrganizationId { get; internal set; }
    [JsonPropertyName(Property.OrganizationName)]
    public string? OrganizationName { get; internal set; }

    [JsonConstructor]
    internal LocationBackupUsage(
        long? revisionsCurrentSize,
        long? revisionsPreviousSize,
        long? revisionsDeletedSize,
        long? localFileFolderSize,
        long? localImageSize,
        long? cloudFileFolderSize,
        long? cloudImageSize,
        long? revisionsTotalSize,
        long? cloudTotalSize,
        long? localTotalSize,
        int? locationId,
        string? locationName,
        string? locationDescription,
        int? organizationId,
        string? organizationName
    ) : base(
        revisionsCurrentSize,
        revisionsPreviousSize,
        revisionsDeletedSize,
        localFileFolderSize,
        localImageSize,
        cloudFileFolderSize,
        cloudImageSize,
        revisionsTotalSize,
        cloudTotalSize,
        localTotalSize
    )
    {
        LocationId = locationId;
        LocationName = locationName;
        LocationDescription = locationDescription;
        OrganizationId = organizationId;
        OrganizationName = organizationName;
    }
}