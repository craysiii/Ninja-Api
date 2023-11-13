namespace NinjaOne_Api.Library.Types;

public class DeviceNote
{
    [JsonPropertyName(Property.Text)]
    public string? Text { get; set; }
}