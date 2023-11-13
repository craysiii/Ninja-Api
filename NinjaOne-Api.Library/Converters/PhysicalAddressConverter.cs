namespace NinjaOne_Api.Library.Converters;

public class PhysicalAddressConverter : JsonConverter<PhysicalAddress>
{
    public override PhysicalAddress? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (string.IsNullOrWhiteSpace(reader.GetString()!)) return null;
        var success = PhysicalAddress.TryParse(reader.GetString()!, out var physicalAddress);
        return success ? physicalAddress : null;
    }

    public override void Write(Utf8JsonWriter writer, PhysicalAddress value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}