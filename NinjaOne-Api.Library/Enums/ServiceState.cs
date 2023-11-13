// ReSharper disable InconsistentNaming
namespace NinjaOne_Api.Library.Enums;

public enum ServiceState
{
    UNKNOWN,
    STOPPED,
    START_PENDING,
    RUNNING,
    STOP_PENDING,
    PAUSE_PENDING,
    PAUSED,
    CONTINUE_PENDING
}