namespace NinjaOne_Api.Library.Types;

public class User : UserBase
{
    [JsonPropertyName(Property.FirstName)]
    public string? FirstName { get; set; }
    [JsonPropertyName(Property.LastName)]
    public string? LastName { get; set; }
    [JsonPropertyName(Property.EmailAddress)]
    public string? EmailAddress { get; set; }
    [JsonPropertyName(Property.PhoneNumber)]
    public string? PhoneNumber { get; set; }
    [JsonPropertyName(Property.Enabled)]
    public bool? Enabled { get; set; }
    [JsonPropertyName(Property.Administrator)]
    public bool? Administrator { get; set; }
    [JsonPropertyName(Property.PermitAllClients)]
    public bool? PermitAllClients { get; set; }
    [JsonPropertyName(Property.NotifyAllClients)]
    public bool? NotifyAllClients { get; set; }
    [JsonPropertyName(Property.MustChangePassword)]
    public bool? MustChangePassword { get; set; }
    [JsonPropertyName(Property.MfaConfigured)]
    public bool? MfaConfigured { get; set; }
    [JsonPropertyName(Property.UserType)]
    public UserType? UserType { get; set; }
    [JsonPropertyName(Property.InvitationStatus)]
    public InvitationStatus? InvitationStatus { get; set; }
    [JsonPropertyName(Property.OrganizationId)]
    public int? OrganizationId { get; set; }
    [JsonPropertyName(Property.DeviceIds)]
    public List<int>? DeviceIds { get; set; }
    [JsonPropertyName(Property.Tags)]
    public List<string>? Tags { get; set; }
    [JsonPropertyName(Property.Fields)]
    public JsonElement? Fields { get; set; }
}