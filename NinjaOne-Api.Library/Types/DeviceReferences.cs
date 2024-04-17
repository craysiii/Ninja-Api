namespace NinjaOne_Api.Library.Types;

public class DeviceReferences
{
    [JsonPropertyName(Property.Organization)]
    public OrganizationBase? Organization { get; internal set; }
    [JsonPropertyName(Property.Location)]
    public Location? Location { get; internal set; }
    [JsonPropertyName(Property.RolePolicy)]
    public Policy? RolePolicy { get; internal set; }
    [JsonPropertyName(Property.Policy)]
    public Policy? Policy { get; internal set; }
    [JsonPropertyName(Property.Role)]
    public DeviceRole? Role { get; internal set; }
    [JsonPropertyName(Property.BackupUsage)]
    public BackupUsageBase? BackupUsage { get; internal set; }

    [JsonConstructor]
    internal DeviceReferences(
        OrganizationBase? organization,
        Location? location,
        Policy? rolePolicy,
        Policy? policy,
        DeviceRole? role,
        BackupUsageBase? backupUsage
    )
    {
        Organization = organization;
        Location = location;
        RolePolicy = rolePolicy;
        Policy = policy;
        Role = role;
        BackupUsage = backupUsage;
    }
}