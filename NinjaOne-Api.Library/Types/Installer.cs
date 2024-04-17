namespace NinjaOne_Api.Library.Types;

public class Installer
{
    [JsonPropertyName(Property.Url)]
    public string? Url { get; internal set; }

    [JsonConstructor]
    internal Installer(string? url)
    {
        Url = url;
    }
}