﻿namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeCustomFields_1
    public async Task<IDictionary<string, JsonElement>> GetOrganizationLocationCustomFields(
        int organizationId,
        int locationId,
        bool? withInheritance = null
        )
    {
        var request = new RestRequest(
            string.Format(Resource.OrganizationLocationCustomFields, organizationId, locationId)
            );
        if (withInheritance is not null) request.AddQueryParameter(Param.WithInheritance, withInheritance.ToString());

        return await GetResource<IDictionary<string, JsonElement>>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeAttributeValues_2
    public async Task<bool> UpdateOrganizationLocationCustomFields(int organizationId, int locationId, Hashtable fields)
    {
        var request = new RestRequest(
            string.Format(Resource.OrganizationLocationCustomFields, organizationId, locationId)
            );

        return await PostResource(request, fields, Method.Patch);
    }
}