namespace NinjaOne_Api.Library.Types;

public class UserBase
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }

    [JsonConstructor]
    internal UserBase(int? id, string? name)
    {
        Id = id;
        Name = name;
    }
}