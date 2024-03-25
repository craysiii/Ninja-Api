namespace NinjaOne_Api.Library.Types;

public class CustomFieldUpdateSource
{
    [JsonPropertyName(Property.Source)]
    public UpdateSource? Source { get; set; }
    [JsonPropertyName(Property.User)]
    public UserBase? User { get; set; }

}