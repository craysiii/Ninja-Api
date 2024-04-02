namespace NinjaOne_Api.Library;

public static class Serializer
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters =
        {
            new UnixTimeStampConverter(),
            new JsonStringEnumConverter(),
            new IPAddressConverter(),
            new PhysicalAddressConverter()
        }
    };
    
    private static readonly JsonSerializerOptions DeserializerOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        Converters =
        {
            new UnixTimeStampConverter(),
            new JsonStringEnumConverter(),
            new IPAddressConverter(),
            new PhysicalAddressConverter()
        }
    };
    
    public static string SerializeObject(object payload)
    {
        return JsonSerializer.Serialize(payload, SerializerOptions);
    }

    public static T DeserializeObject<T>(JsonElement payload)
    {
        return JsonSerializer.Deserialize<T>(payload.ToString() ?? string.Empty, DeserializerOptions)!;
    }

    public static List<T> DeserializeList<T>(JsonElement payload)
    {
        return payload.EnumerateArray().Select(DeserializeObject<T>).ToList();
    }
}