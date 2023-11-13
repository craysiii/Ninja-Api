namespace NinjaOne_Api.Library.Types;

public class WindowsService
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.DisplayName)]
    public string? DisplayName { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.StartType)]
    public ServiceStartType? StartType { get; set; }
    [JsonPropertyName(Property.UserName)]
    public string? UserName { get; set; }
    [JsonPropertyName(Property.State)]
    public ServiceState? State { get; set; }
}