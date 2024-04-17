namespace NinjaOne_Api.Library.Types;

public class CustomFieldUpdateSource
{
    [JsonPropertyName(Property.Source)]
    public UpdateSource? Source { get; internal set; }
    [JsonPropertyName(Property.User)]
    public UserBase? User { get; internal set; }

    [JsonConstructor]
    internal CustomFieldUpdateSource(UpdateSource? source, UserBase? user)
    {
        Source = source;
        User = user;
    }
}