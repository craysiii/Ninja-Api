namespace NinjaOne_Api.Library.Types;

public class LoggedOnUser
{
    [JsonPropertyName(Property.UserName)]
    public string? UserName { get; set; }
    [JsonPropertyName(Property.LogonTime)]
    public DateTime? LogonTime { get; set; }
}