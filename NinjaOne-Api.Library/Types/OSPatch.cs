namespace NinjaOne_Api.Library.Types;

public class OSPatch : OSPatchBase
{
    [JsonPropertyName(Property.Status)]
    public OSPatchStatus? Status { get; internal set; }
    
    [JsonConstructor]
    internal OSPatch(
        Guid? id,
        string? name,
        OSPatchSeverity? severity,
        OSPatchType? type,
        DateTime? installedAt,
        string? kbNumber,
        OSPatchStatus? status
    ) : base(
        id,
        name,
        severity,
        type,
        installedAt,
        kbNumber
    )
    {
        Status = status;
    }
}