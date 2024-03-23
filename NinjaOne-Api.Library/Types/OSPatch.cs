namespace NinjaOne_Api.Library.Types;

public class 
    OSPatch : OSPatchBase
{
    [JsonPropertyName(Property.Status)]
    public OSPatchStatus Status { get; set; }
}