namespace NinjaOne_Api.Library;

public static class Serializer
{
    public static string SerializeObject(object payload)
    {
        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        return JsonSerializer.Serialize(payload, options);
    }

    public static T DeserializeObject<T>(JsonElement payload)
    {
        var options = new JsonSerializerOptions
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };
        
        options.Converters.Add(new UnixTimeStampConverter());
        options.Converters.Add(new JsonStringEnumConverter());
        options.Converters.Add(new IPAddressConverter());
        options.Converters.Add(new PhysicalAddressConverter());
        
        return JsonSerializer.Deserialize<T>(payload.ToString() ?? "", options)!;
    }

    public static List<T> DeserializeList<T>(JsonElement payload)
    {
        return payload.EnumerateArray().Select(DeserializeObject<T>).ToList();
    }
}