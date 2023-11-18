// ReSharper disable InconsistentNaming
namespace NinjaOne_Api.Library.Enums;

public enum BitLockerEncryptionMethod
{
    NONE,
    AES_128_WITH_DIFFUSER,
    AES_256_WITH_DIFFUSER,
    AES_128,
    AES_256,
    HARDWARE_ENCRYPTION,
    XTS_AES_128,
    XTS_AES_256,
    UNKNOWN
}