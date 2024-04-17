namespace NinjaOne_Api.Library.Types;

public class LoggedOnUser
{
    [JsonPropertyName(Property.UserName)]
    public string? UserName { get; internal set; }
    [JsonPropertyName(Property.LogonTime)]
    public DateTime? LogonTime { get; internal set; }

    [JsonConstructor]
    internal LoggedOnUser(string? userName, DateTime? logonTime)
    {
        UserName = userName;
        LogonTime = logonTime;
    }
}