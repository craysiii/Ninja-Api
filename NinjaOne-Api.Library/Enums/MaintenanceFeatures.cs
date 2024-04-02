namespace NinjaOne_Api.Library.Enums;

[Flags]
public enum MaintenanceFeatures
{
    ALERTS = 1,
    PATCHING = 2,
    AVSCANS = 4,
    TASKS = 8
}