namespace NinjaOne_Api.Library.Types;

public class Location
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.OrganizationId)]
    public int? OrganizationId { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Address)]
    public string? Address { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.UserData)]
    public JsonElement? UserData { get; set; }
    [JsonPropertyName(Property.Tags)]
    public List<string>? Tags { get; set; }
    [JsonPropertyName(Property.Fields)]
    public JsonElement? Fields { get; set; }

    public Location()
    {
        
    }

    public Location(
        string name,
        string? address = null,
        string? description = null,
        JsonElement? userData = null,
        List<string>? tags = null,
        JsonElement? fields = null
        )
    {
        Name = name;
        Address = address;
        Description = description;
        UserData = userData;
        Tags = tags;
        Fields = fields;
    }

    [JsonConstructor]
    internal Location(
        int? id,
        int? organizationId,
        string? name,
        string? address,
        string? description,
        JsonElement? userData,
        List<string>? tags,
        JsonElement? fields
        )
    {
        Id = id;
        OrganizationId = organizationId;
        Name = name;
        Address = address;
        Description = description;
        UserData = userData;
        Tags = tags;
        Fields = fields;
    }

    public Location UpdateLocationDto()
    {
        return new Location
        {
            Name = Name,
            Address = Address,
            Description = Description,
            UserData = UserData,
            Tags = Tags,
            Fields = Fields
        };
    }
}