// ReSharper disable InconsistentNaming
namespace NinjaOne_Api.Library.Enums;

public enum BitLockerConversionStatus
{
    FULLY_DECRYPTED,
    FULLY_ENCRYPTED,
    ENCRYPTION_IN_PROGRESS,
    DECRYPTION_IN_PROGRESS,
    ENCRYPTION_PAUSED,
    DECRYPTION_PAUSED,
    UNKNOWN
}