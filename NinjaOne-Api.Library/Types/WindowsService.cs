namespace NinjaOne_Api.Library.Types;

public class WindowsService
{
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.DisplayName)]
    public string? DisplayName { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.StartType)]
    public ServiceStartType? StartType { get; internal set; }
    [JsonPropertyName(Property.UserName)]
    public string? UserName { get; internal set; }
    [JsonPropertyName(Property.State)]
    public ServiceState? State { get; internal set; }

    [JsonConstructor]
    internal WindowsService(
        string? name,
        string? displayName,
        string? description,
        ServiceStartType? startType,
        string? userName,
        ServiceState? state
    )
    {
        Name = name;
        DisplayName = displayName;
        Description = description;
        StartType = startType;
        UserName = userName;
        State = state;
    }
}