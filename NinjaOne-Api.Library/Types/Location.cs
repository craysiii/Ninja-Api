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

    public Location()
    {
        
    }

    public Location(
        string name,
        string? address = null,
        string? description = null
        )
    {
        Name = name;
        Address = address;
        Description = description;
    }

    [JsonConstructor]
    internal Location(int? id, int? organizationId, string? name, string? address, string? description)
    {
        Id = id;
        OrganizationId = organizationId;
        Name = name;
        Address = address;
        Description = description;
    }

    public Location UpdateLocationDto()
    {
        return new Location
        {
            Name = Name,
            Address = Address,
            Description = Description
        };
    }
}