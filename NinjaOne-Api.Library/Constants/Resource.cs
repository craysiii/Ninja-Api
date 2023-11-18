namespace NinjaOne_Api.Library.Constants;

public static class Resource
{
    public const string Activities                          = "activities";
    public const string Alerts                              = "alerts";
    public const string CustomFieldDefinitions              = "device-custom-fields";
    public const string DetailedCustomFieldReport           = "queries/custom-fields-detailed";
    public const string Device                              = "/device/{0}";
    public const string DeviceActivities                    = $"{Device}/activities";
    public const string DeviceCustomFields                  = $"{Device}/custom-fields";
    public const string DeviceLastLoggedOnUser              = $"{Device}/last-logged-on-user";
    public const string Devices                             = "devices";
    public const string DevicesDetailed                     = "devices-detailed";
    public const string DeviceSearch                        = $"{Devices}/search";
    public const string DevicePolicyOverrides               = $"{Device}/policy/overrides";
    public const string DeviceInstalledOSPatches            = $"{Device}/os-patch-installs";
    public const string DeviceOSPatches                     = $"{Device}/os-patches";
    public const string DeviceSoftwareInventory             = $"{Device}/software";
    public const string DeviceSoftwarePatchStatus           = $"{Device}/software-patches";
    public const string DeviceWindowsServices               = $"{Device}/windows-services";
    public const string GenerateInstaller                   = "organization/generate-installer";
    public const string Groups                              = "groups";
    public const string GroupMembers                        = "group/{0}/device-ids";
    public const string Jobs                                = "jobs";
    public const string Locations                           = "locations";
    public const string Organization                        = "organization/{0}";
    public const string OrganizationDevices                 = $"{Organization}/devices";
    public const string OrganizationDocument                = $"{Organization}/document/{{1}}";
    public const string OrganizationDocuments               = $"{Organization}/documents";
    public const string OrganizationCustomFields            = $"{Organization}/custom-fields";
    public const string OrganizationLocations               = $"{Organization}/locations";
    public const string OrganizationLocationCustomFields    = $"{Organization}/location/{{1}}/custom-fields";
    public const string OrganizationLocationBackup          = $"{Organization}/location/{{1}}/backup/usage";
    public const string OrganizationLocationBackups         = $"{OrganizationLocations}/backup/usage";
    public const string OrganizationUsers                   = $"{Organization}/end-users";
    public const string Organizations                       = "organizations";
    public const string OrganizationsDetailed               = "organizations-detailed";
    public const string Policies                            = "policies";
    public const string Roles                               = "roles";
    public const string SoftwareProducts                    = "software-products";
    public const string Tasks                               = "tasks";
    public const string Token                               = "ws/oauth/token";
    public const string Users                               = "users";
}