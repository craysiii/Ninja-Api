namespace NinjaOne_Api.Library.Types;

public class DeviceMaintenance
{
    [JsonPropertyName(Property.Status)]
    public MaintenanceStatus? Status { get; internal set; }
    [JsonPropertyName(Property.Start)]
    public DateTime? Start { get; internal set; }
    [JsonPropertyName(Property.End)]
    public DateTime? End { get; internal set; }

    [JsonConstructor]
    internal DeviceMaintenance(MaintenanceStatus? status, DateTime? start, DateTime? end)
    {
        Status = status;
        Start = start;
        End = end;
    }
}