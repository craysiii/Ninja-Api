namespace NinjaOne_Api.Library.Types;

public class OrganizationSettings
{
    [JsonPropertyName(Property.TrayIcon)]
    public OrganizationProductSetting? TrayIcon { get; set; }
    [JsonPropertyName(Property.Splashtop)]
    public OrganizationProductSetting? Splashtop { get; set; }
    [JsonPropertyName(Property.Teamviewer)]
    public OrganizationProductSetting? Teamviewer { get; set; }
    [JsonPropertyName(Property.Backup)]
    public OrganizationProductSetting? Backup { get; set; }
    [JsonPropertyName(Property.Psa)]
    public OrganizationProductSetting? Psa { get; set; }
}