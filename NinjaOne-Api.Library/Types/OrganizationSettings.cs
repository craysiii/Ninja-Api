namespace NinjaOne_Api.Library.Types;

public class OrganizationSettings
{
    [JsonPropertyName(Property.TrayIcon)]
    public OrganizationProductSetting? TrayIcon { get; internal set; }
    [JsonPropertyName(Property.Splashtop)]
    public OrganizationProductSetting? Splashtop { get; internal set; }
    [JsonPropertyName(Property.Teamviewer)]
    public OrganizationProductSetting? Teamviewer { get; internal set; }
    [JsonPropertyName(Property.Backup)]
    public OrganizationProductSetting? Backup { get; internal set; }
    [JsonPropertyName(Property.Psa)]
    public OrganizationProductSetting? Psa { get; internal set; }

    [JsonConstructor]
    internal OrganizationSettings(
        OrganizationProductSetting? trayIcon,
        OrganizationProductSetting? splashtop,
        OrganizationProductSetting? teamviewer,
        OrganizationProductSetting? backup,
        OrganizationProductSetting? psa
    )
    {
        TrayIcon = trayIcon;
        Splashtop = splashtop;
        Teamviewer = teamviewer;
        Backup = backup;
        Psa = psa;
    }
}