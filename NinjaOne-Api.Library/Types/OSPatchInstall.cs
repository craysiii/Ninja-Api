namespace NinjaOne_Api.Library.Types;

public class OSPatchInstall : OSPatchBase
{
    [JsonPropertyName(Property.Status)]
    public OSPatchInstallStatus? Status { get; internal set; }

    [JsonConstructor]
    internal OSPatchInstall(
        Guid? id,
        string? name,
        OSPatchSeverity? severity,
        OSPatchType? type,
        DateTime? installedAt,
        string? kbNumber,
        OSPatchInstallStatus? status
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