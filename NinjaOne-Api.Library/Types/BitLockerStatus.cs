namespace NinjaOne_Api.Library.Types;

public class BitLockerStatus
{
    [JsonPropertyName(Property.ConversionStatus)]
    public BitLockerConversionStatus? ConversionStatus { get; set; }
    [JsonPropertyName(Property.EncryptionMethod)]
    public BitLockerEncryptionMethod? EncryptionMethod { get; set; }
    [JsonPropertyName(Property.ProtectionStatus)]
    public BitLockerProtectionStatus? ProtectionStatus { get; set; }
    [JsonPropertyName(Property.LockStatus)]
    public BitLockerLockStatus? LockStatus { get; set; }
    [JsonPropertyName(Property.InitializedForProtection)]
    public bool? InitializedForProtection { get; set; }
}