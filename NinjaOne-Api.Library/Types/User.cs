namespace NinjaOne_Api.Library.Types;

public class User : UserBase
{
    [JsonPropertyName(Property.FirstName)]
    public string? FirstName { get; internal set; }
    [JsonPropertyName(Property.LastName)]
    public string? LastName { get; internal set; }
    [JsonPropertyName(Property.EmailAddress)]
    public string? EmailAddress { get; internal set; }
    [JsonPropertyName(Property.PhoneNumber)]
    public string? PhoneNumber { get; internal set; }
    [JsonPropertyName(Property.Enabled)]
    public bool? Enabled { get; internal set; }
    [JsonPropertyName(Property.Administrator)]
    public bool? Administrator { get; internal set; }
    [JsonPropertyName(Property.PermitAllClients)]
    public bool? PermitAllClients { get; internal set; }
    [JsonPropertyName(Property.NotifyAllClients)]
    public bool? NotifyAllClients { get; internal set; }
    [JsonPropertyName(Property.MustChangePassword)]
    public bool? MustChangePassword { get; internal set; }
    [JsonPropertyName(Property.MfaConfigured)]
    public bool? MfaConfigured { get; internal set; }
    [JsonPropertyName(Property.UserType)]
    public UserType? UserType { get; internal set; }
    [JsonPropertyName(Property.InvitationStatus)]
    public InvitationStatus? InvitationStatus { get; internal set; }
    [JsonPropertyName(Property.OrganizationId)]
    public int? OrganizationId { get; internal set; }
    [JsonPropertyName(Property.DeviceIds)]
    public List<int>? DeviceIds { get; internal set; }

    internal User(
        int? id,
        string? name,
        string? firstName,
        string? lastName,
        string? emailAddress,
        string? phoneNumber,
        bool? enabled,
        bool? administrator,
        bool? permitAllClients,
        bool? notifyAllClients,
        bool? mustChangePassword,
        bool? mfaConfigured,
        UserType? userType,
        InvitationStatus? invitationStatus,
        int? organizationId,
        List<int>? deviceIds
    ) : base(
        id,
        name
    )
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        PhoneNumber = phoneNumber;
        Enabled = enabled;
        Administrator = administrator;
        PermitAllClients = permitAllClients;
        NotifyAllClients = notifyAllClients;
        MustChangePassword = mustChangePassword;
        MfaConfigured = mfaConfigured;
        UserType = userType;
        InvitationStatus = invitationStatus;
        OrganizationId = organizationId;
        DeviceIds = deviceIds;
    }
}