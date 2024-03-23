namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganization
    public async Task<(Organization? Organization, NinjaApiError? Error)> GetOrganization(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.Organization, organizationId));

        return await GetResource<Organization>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeCustomFields_2
    public async Task<(Dictionary<string, JsonElement>? CustomFields, NinjaApiError? Error)> 
        GetOrganizationCustomFields(
            int organizationId
            )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationCustomFields, organizationId));

        return await GetResource<Dictionary<string, JsonElement>>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeAttributeValues_1
    public async Task<(bool Success, NinjaApiError? Error)> UpdateOrganizationCustomFields(
        int organizationId, 
        Hashtable fields
        )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationCustomFields, organizationId));

        return await PostResource(request, fields, Method.Patch);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationLocationUsage
    public async Task<(List<LocationBackupUsage>? LocationBackupUsages, NinjaApiError? Error)>
        GetOrganizationLocationBackupUsages(
            int organizationId
            )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationLocationBackups, organizationId));

        return await GetResources<LocationBackupUsage>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationLocations
    public async Task<(List<Location>? Locations, NinjaApiError? Error)> GetOrganizationLocations(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationLocations, organizationId));

        return await GetResources<Location>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateOrganizationDocument
    public async Task<(OrganizationDocument?, NinjaApiError?)> UpdateOrganizationDocument(
        int organizationId,
        int documentId,
        DocumentUpdate documentUpdate
        )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDocument, organizationId, documentId));

        return await PostResource<OrganizationDocument>(request, documentUpdate);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getLocationUsage
    public async Task<(LocationBackupUsage? LocationBackupUsage, NinjaApiError? Error)> 
        GetOrganizationLocationBackupUsage(
            int organizationId, 
            int locationId
            )
    {
        var request = new RestRequest(
            string.Format(Resource.OrganizationLocationBackup, organizationId, locationId)
            );

        return await GetResource<LocationBackupUsage>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationDocuments
    public async Task<(List<OrganizationDocument>? OrganizationDocuments, NinjaApiError? Error)> 
        GetOrganizationDocuments(
            int organizationId
            )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDocuments, organizationId));

        return await GetResources<OrganizationDocument>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationDevices
    public async Task<(List<DeviceBase>? Devices, NinjaApiError? Error)> GetOrganizationDevices(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDevices, organizationId));

        return await GetResources<DeviceBase>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getEndUsers
    public async Task<(List<User>? EndUsers, NinjaApiError? Error)> GetOrganizationEndUsers(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationUsers, organizationId));

        return await GetResources<User>(request);
    }
}