namespace NinjaOne_Api.Library;

public partial class Client
{
    /// <summary>
    /// Get the custom fields for a specific location<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeCustomFields_1">getNodeCustomFields_1</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// <param name="locationId">Id of the location</param>
    /// <param name="withInheritance">Inherit custom fields from the location's organization</param>
    /// <example>
    /// <code>
    /// var result = await client.GetOrganizationLocationCustomFields(
    ///     organizationId: 1,
    ///     locationId: 5,
    ///     withInheritance: true
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable Dictionary with custom field key value pairs and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(Dictionary<string, JsonElement>? CustomFields, NinjaApiError? Error)> 
        GetOrganizationLocationCustomFields(
            int organizationId,
            int locationId,
            bool? withInheritance = null
            )
    {
        var request = new RestRequest(
            string.Format(Resource.OrganizationLocationCustomFields, organizationId, locationId)
            );
        if (withInheritance is not null) request.AddQueryParameter(Param.WithInheritance, withInheritance.ToString());

        return await GetResource<Dictionary<string, JsonElement>>(request);
    }
    
    /// <summary>
    /// Update a set of custom fields for a location<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeAttributeValues_2">updateNodeAttributeValues_2</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// <param name="locationId">Id of the location</param>
    /// <param name="fields">Hashtable containing key value pairs of the fields to update</param>
    /// <example>
    /// <code>
    /// var result = await client.UpdateOrganizationLocationCustomFields(
    ///     organizationId: 1,
    ///     locationId: 5,
    ///     new Hashtable
    ///     {
    ///         {"locationCode", "SPA"}
    ///     }
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> UpdateOrganizationLocationCustomFields(
        int organizationId,
        int locationId,
        Hashtable fields
        )
    {
        var request = new RestRequest(
            string.Format(Resource.OrganizationLocationCustomFields, organizationId, locationId)
            );

        return await PostResource(request, fields, Method.Patch);
    }
}