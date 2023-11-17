// ReSharper disable InconsistentNaming
namespace NinjaOne_Api.Library.Enums;

[Flags]
public enum ApplicationScopes
{
    MONITORING = 1,
    MANAGEMENT = 2,
    CONTROL = 4,
    OFFLINE_ACCESS = 8
}