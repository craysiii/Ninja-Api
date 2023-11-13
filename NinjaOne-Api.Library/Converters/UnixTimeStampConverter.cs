namespace NinjaOne_Api.Library.Converters;

public class UnixTimeStampConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetDouble();
        if (value <= 253402300799) value *= 1000;
        return DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(value)).UtcDateTime;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}