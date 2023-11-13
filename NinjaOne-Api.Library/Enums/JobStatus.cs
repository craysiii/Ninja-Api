// ReSharper disable InconsistentNaming
namespace NinjaOne_Api.Library.Enums;

public enum JobStatus
{
    START_REQUESTED,
    STARTED,
    IN_PROCESS,
    COMPLETED,
    CANCEL_REQUESTED,
    CANCELLED,
    TRIGGERED,
    RESET,
    ACKNOWLEDGED,
    DISABLED
}