namespace NinjaOne_Api.Library.Types;

public class OSPatchInstall : OSPatchBase
{
    [JsonPropertyName(Property.Status)]
    public OSPatchInstallStatus Status { get; set; }
}