using System.Text.Json.Nodes;

namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganization
    public async Task<Organization> GetOrganization(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.Organization, organizationId));

        return await GetResource<Organization>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeCustomFields_2
    public async Task<IDictionary<string, JsonElement>> GetOrganizationCustomFields(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationCustomFields, organizationId));

        return await GetResource<IDictionary<string, JsonElement>>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeAttributeValues_1
    public async Task<bool> UpdateOrganizationCustomFields(int organizationId, Hashtable fields)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationCustomFields, organizationId));

        return await PostResource(request, fields, Method.Patch);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationLocationUsage
    public async Task<IList<LocationBackupUsage>> GetOrganizationLocationBackupUsages(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationLocationBackups, organizationId));

        return await GetResources<LocationBackupUsage>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationLocations
    public async Task<IList<Location>> GetOrganizationLocations(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationLocations, organizationId));

        return await GetResources<Location>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateOrganizationDocument
    public async Task<OrganizationDocument> UpdateOrganizationDocument(
        int organizationId,
        int documentId,
        DocumentUpdate documentUpdate
        )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDocument, organizationId, documentId));

        return await PostResource<OrganizationDocument>(request, documentUpdate);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getLocationUsage
    public async Task<LocationBackupUsage> GetOrganizationLocationBackupUsage(int organizationId, int locationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationLocationBackup, organizationId, locationId));

        return await GetResource<LocationBackupUsage>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationDocuments
    public async Task<IList<OrganizationDocument>> GetOrganizationDocuments(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDocuments, organizationId));

        return await GetResources<OrganizationDocument>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationDevices
    public async Task<IList<DeviceBase>> GetOrganizationDevices(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDevices, organizationId));

        return await GetResources<DeviceBase>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getEndUsers
    public async Task<IList<User>> GetOrganizationEndUsers(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationUsers, organizationId));

        return await GetResources<User>(request);
    }
}