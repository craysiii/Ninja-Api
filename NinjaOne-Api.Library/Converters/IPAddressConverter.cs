namespace NinjaOne_Api.Library.Converters;

public class IPAddressConverter : JsonConverter<IPAddress>
{
    public override IPAddress? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (string.IsNullOrWhiteSpace(reader.GetString()!)) return null;
        var success = IPAddress.TryParse(reader.GetString()!, out var ipAddress);
        return success ? ipAddress : null;
    }

    public override void Write(Utf8JsonWriter writer, IPAddress value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}