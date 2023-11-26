namespace NinjaOne_Api.Library.Types;

public class OSPatchQuery
{
    [JsonPropertyName(Property.Cursor)]
    public Cursor? Cursor { get; set; }
    [JsonPropertyName(Property.Results)]
    public IList<OSPatch>? Results { get; set; }
}