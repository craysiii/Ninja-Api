namespace NinjaOne_Api.Library.Types;

public class UserBase
{
    [JsonPropertyName(Property.Id)]
    public int Id { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
}