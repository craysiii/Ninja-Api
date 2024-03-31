namespace NinjaOne_Api.Library;

public partial class Client
{
    /// <summary>
    /// Get a specific organization<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganization">getOrganization</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// <example>
    /// <code>
    /// var result = await client.GetOrganization(
    ///     organizationId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="Organization"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(Organization? Organization, NinjaApiError? Error)> GetOrganization(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.Organization, organizationId));

        return await GetResource<Organization>(request);
    }
    
    /// <summary>
    /// Get a list of organization custom fields<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeCustomFields_2">getNodeCustomFields_2</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// <example>
    /// <code>
    /// var result = await client.GetOrganizationCustomFields(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable Dictionary with custom field key value pairs and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(Dictionary<string, JsonElement>? CustomFields, NinjaApiError? Error)> 
        GetOrganizationCustomFields(
            int organizationId
            )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationCustomFields, organizationId));

        return await GetResource<Dictionary<string, JsonElement>>(request);
    }
    
    /// <summary>
    /// Update a set of custom fields for an organization<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeAttributeValues_1">updateNodeAttributeValues_1</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// <param name="fields">Hashtable containing key value pairs of the fields to update</param>
    /// <example>
    /// <code>
    /// var result = await client.UpdateOrganizationCustomFields(
    ///     organizationId: 1,
    ///     new Hashtable
    ///     {
    ///         {"service_api_key", "api_key"}
    ///     }
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> UpdateOrganizationCustomFields(
        int organizationId, 
        Hashtable fields
        )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationCustomFields, organizationId));

        return await PostResource(request, fields, Method.Patch);
    }
    
    /// <summary>
    /// Get an organization's backup usage by location<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationLocationUsage">getOrganizationLocationUsage</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// /// <example>
    /// <code>
    /// var result = await client.GetOrganizationLocationBackupUsages(
    ///     organizationId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="LocationBackupUsage"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<LocationBackupUsage>? LocationBackupUsages, NinjaApiError? Error)>
        GetOrganizationLocationBackupUsages(
            int organizationId
            )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationLocationBackups, organizationId));

        return await GetResources<LocationBackupUsage>(request);
    }
    
    /// <summary>
    /// Get an organization's locations<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationLocations">getOrganizationLocations</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// /// <example>
    /// <code>
    /// var result = await client.GetOrganizationLocations(
    ///     organizationId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Location"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Location>? Locations, NinjaApiError? Error)> GetOrganizationLocations(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationLocations, organizationId));

        return await GetResources<Location>(request);
    }
    
    /// <summary>
    /// Update an organization document<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateOrganizationDocument">updateOrganizationDocument</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// <param name="documentId">Id of the document</param>
    /// <param name="documentUpdate">Object containing modifications</param>
    /// /// <example>
    /// <code>
    /// var result = await client.UpdateOrganizationDocument(
    ///     organizationId: 1,
    ///     documentId: 5,
    ///     new DocumentUpdate
    ///     {
    ///         DocumentName = "Test Document",
    ///         DocumentDescription = "A document to show off features"
    ///     }
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="OrganizationDocument"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(OrganizationDocument?, NinjaApiError?)> UpdateOrganizationDocument(
        int organizationId,
        int documentId,
        DocumentUpdate documentUpdate
        )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDocument, organizationId, documentId));

        return await PostResource<OrganizationDocument>(request, documentUpdate);
    }
    
    /// <summary>
    /// Get the backup usage for a specific organization location<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getLocationUsage">getLocationUsage</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// <param name="locationId">Id of the location</param>
    /// /// <example>
    /// <code>
    /// var result = await client.GetOrganizationLocationBackupUsage(
    ///     organizationId: 1,
    ///     locationId: 5
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="LocationBackupUsage"/> and a nullable <see cref="NinjaApiError"/></returns>
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
    
    /// <summary>
    /// Get documents belonging to an organization<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationDocuments">getOrganizationDocuments</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// /// <example>
    /// <code>
    /// var result = await client.GetOrganizationDocuments(
    ///     organizationId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="OrganizationDocument"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<OrganizationDocument>? OrganizationDocuments, NinjaApiError? Error)> 
        GetOrganizationDocuments(
            int organizationId
            )
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDocuments, organizationId));

        return await GetResources<OrganizationDocument>(request);
    }
    
    /// <summary>
    /// Get devices belonging to an organization<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationDevices">getOrganizationDevices</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// /// <example>
    /// <code>
    /// var result = await client.GetOrganizationDevices(
    ///     organizationId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="DeviceBase"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<DeviceBase>? Devices, NinjaApiError? Error)> GetOrganizationDevices(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationDevices, organizationId));

        return await GetResources<DeviceBase>(request);
    }
    
    /// <summary>
    /// Get end users assigned to an organization<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getEndUsers">getEndUsers</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// /// <example>
    /// <code>
    /// var result = await client.GetOrganizationEndUsers(
    ///     organizationId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="User"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<User>? EndUsers, NinjaApiError? Error)> GetOrganizationEndUsers(int organizationId)
    {
        var request = new RestRequest(string.Format(Resource.OrganizationUsers, organizationId));

        return await GetResources<User>(request);
    }
}