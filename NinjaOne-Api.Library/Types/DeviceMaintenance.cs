namespace NinjaOne_Api.Library.Types;

public class DeviceMaintenance
{
    [JsonPropertyName(Property.Status)]
    public MaintenanceStatus? Status { get; set; }
    [JsonPropertyName(Property.Start)]
    public DateTime? Start { get; set; }
    [JsonPropertyName(Property.End)]
    public DateTime? End { get; set; }
}