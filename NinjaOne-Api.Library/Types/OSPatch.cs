namespace NinjaOne_Api.Library.Types;

public class OSPatch : OSPatchBase
{
    [JsonPropertyName(Property.Status)]
    public OSPatchStatus? Status { get; set; }
    [JsonPropertyName(Property.DeviceId)]
    public int? DeviceId { get; set; }
    [JsonPropertyName(Property.Timestamp)]
    public DateTime? Timestamp { get; set; }
}