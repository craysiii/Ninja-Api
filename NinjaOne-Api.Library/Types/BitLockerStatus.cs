namespace NinjaOne_Api.Library.Types;

public class BitLockerStatus
{
    [JsonPropertyName(Property.ConversionStatus)]
    public BitLockerConversionStatus? ConversionStatus { get; internal set; }
    [JsonPropertyName(Property.EncryptionMethod)]
    public BitLockerEncryptionMethod? EncryptionMethod { get; internal set; }
    [JsonPropertyName(Property.ProtectionStatus)]
    public BitLockerProtectionStatus? ProtectionStatus { get; internal set; }
    [JsonPropertyName(Property.LockStatus)]
    public BitLockerLockStatus? LockStatus { get; internal set; }
    [JsonPropertyName(Property.InitializedForProtection)]
    public bool? InitializedForProtection { get; internal set; }

    [JsonConstructor]
    internal BitLockerStatus(
        BitLockerConversionStatus? conversionStatus,
        BitLockerEncryptionMethod? encryptionMethod,
        BitLockerProtectionStatus? protectionStatus,
        BitLockerLockStatus? lockStatus,
        bool? initializedForProtection
    )
    {
        ConversionStatus = conversionStatus;
        EncryptionMethod = encryptionMethod;
        ProtectionStatus = protectionStatus;
        LockStatus = lockStatus;
        InitializedForProtection = initializedForProtection;
    }
}