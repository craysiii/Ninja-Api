namespace NinjaOne_Api.Library.Types;

public class DeviceReferences
{
    [JsonPropertyName(Property.Organization)]
    public OrganizationBase? Organization { get; set; }
    [JsonPropertyName(Property.Location)]
    public Location? Location { get; set; }
    [JsonPropertyName(Property.RolePolicy)]
    public Policy? RolePolicy { get; set; }
    [JsonPropertyName(Property.Policy)]
    public Policy? Policy { get; set; }
    [JsonPropertyName(Property.Role)]
    public DeviceRole? Role { get; set; }
    [JsonPropertyName(Property.BackupUsage)]
    public BackupUsageBase? BackupUsage { get; set; }
}