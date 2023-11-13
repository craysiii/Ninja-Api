namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizations
    public async Task<IList<OrganizationBase>> GetOrganizations(int after = 0, int pageSize = DefaultMaxPageSize)
    {
        var request = new RestRequest(Resource.Organizations);
        request.AddQueryParameter(Param.After, after);
        request.AddQueryParameter(Param.PageSize, pageSize);
        
        return await GetResources<OrganizationBase>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/search
    public async Task<DeviceQuery> QueryDevices(string query, int limit = int.MaxValue)
    {
        var request = new RestRequest(Resource.DeviceSearch);
        request.AddQueryParameter(Param.Query, query);
        request.AddQueryParameter(Param.Limit, limit);
        
        return await GetResource<DeviceQuery>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceGlobalCustomFields
    public async Task<IList<DeviceCustomField>> GetGlobalDeviceCustomFields()
    {
        var request = new RestRequest(Resource.CustomFieldDefinitions);
        
        return await GetResources<DeviceCustomField>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getPolicies
    public async Task<IList<Policy>> GetPolicies()
    {
        var request = new RestRequest(Resource.Policies);
        
        return await GetResources<Policy>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getAlerts
    public async Task<IList<Alert>> GetAlerts(
        string? deviceFilter = null,
        string? language = null,
        SourceType? sourceType = null,
        string? timeZone = null
        )
    {
        var request = new RestRequest(Resource.Alerts);
        if (!string.IsNullOrWhiteSpace(deviceFilter)) request.AddQueryParameter(Param.DeviceFilter, deviceFilter);
        if (!string.IsNullOrWhiteSpace(language)) request.AddQueryParameter(Param.Language, language);
        if (sourceType is not null) request.AddQueryParameter(Param.SourceType, sourceType.Value.ToString());
        if (!string.IsNullOrWhiteSpace(timeZone)) request.AddQueryParameter(Param.TimeZone, timeZone);
        
        return await GetResources<Alert>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationsDetailed
    public async Task<IList<Organization>> GetOrganizationsDetailed(int after = 0, int pageSize = DefaultMaxPageSize)
    {
        var request = new RestRequest(Resource.OrganizationsDetailed);
        request.AddQueryParameter(Param.After, after);
        request.AddQueryParameter(Param.PageSize, pageSize);
        
        return await GetResources<Organization>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeRoles
    public async Task<IList<DeviceRole>> GetDeviceRoles()
    {
        var request = new RestRequest(Resource.Roles);
        
        return await GetResources<DeviceRole>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getSoftwareProducts
    public async Task<IList<SoftwareProduct>> GetSoftwareProducts()
    {
        var request = new RestRequest(Resource.SoftwareProducts);
        
        return await GetResources<SoftwareProduct>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevicesDetailed
    public async Task<IList<Device>> GetDevicesDetailed(
        string? deviceFilter = null,
        int after = 0,
        int pageSize = DefaultMaxPageSize
        )
    {
        var request = new RestRequest(Resource.DevicesDetailed);
        if (!string.IsNullOrWhiteSpace(deviceFilter)) request.AddQueryParameter(Param.DeviceFilter, deviceFilter);
        request.AddQueryParameter(Param.After, after);
        request.AddQueryParameter(Param.PageSize, pageSize);
        
        return await GetResources<Device>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getActiveJobs
    public async Task<IList<Job>> GetActiveJobs(
        string? deviceFilter = null,
        string? language = null,
        SourceType? sourceType = null,
        string? timeZone = null
        )
    {
        var request = new RestRequest(Resource.Jobs);
        if (!string.IsNullOrWhiteSpace(deviceFilter)) request.AddQueryParameter(Param.DeviceFilter, deviceFilter);
        if (!string.IsNullOrWhiteSpace(language)) request.AddQueryParameter(Param.Language, language);
        if (sourceType is not null) request.AddQueryParameter(Param.SourceType, sourceType.Value.ToString());
        if (!string.IsNullOrWhiteSpace(timeZone)) request.AddQueryParameter(Param.TimeZone, timeZone);
        
        return await GetResources<Job>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getScheduledTasks
    public async Task<IList<ScheduledTask>> GetScheduledTasks()
    {
        var request = new RestRequest(Resource.Tasks);
        
        return await GetResources<ScheduledTask>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getUsers
    public async Task<IList<User>> GetUsers()
    {
        var request = new RestRequest(Resource.Users);
        
        return await GetResources<User>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getGroups
    public async Task<IList<Group>> GetGroups()
    {
        var request = new RestRequest(Resource.Groups);
        
        return await GetResources<Group>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevices
    public async Task<IList<DeviceBase>> GetDevices(
        string? deviceFilter = null,
        int after = 0,
        int pageSize = DefaultMaxPageSize
        )
    {
        var request = new RestRequest(Resource.Devices);
        request.AddQueryParameter(Param.After, after);
        request.AddQueryParameter(Param.PageSize, pageSize);
        if (!string.IsNullOrWhiteSpace(deviceFilter)) request.AddQueryParameter(Param.DeviceFilter, deviceFilter);
        
        return await GetResources<DeviceBase>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getActivities
    public async Task<ActivityQueryResult> GetActivities(
        DateTime? after = null,
        DateTime? before = null,
        ActivityClass? activityClass = null,
        string? deviceFilter = null,
        string? language = null,
        int? newerThan = null,
        int? olderThan = null,
        int pageSize = DefaultMaxPageSize,
        Guid? seriesUid = null,
        Guid? sourceConfigUid = null,
        StatusCode? status = null,
        ActivityType? type = null,
        string? timeZone = null,
        string? user = null
        )
    {
        var request = new RestRequest(Resource.Activities);
        if (after is not null) request.AddQueryParameter(Param.After, UnixTime(after.Value));
        if (before is not null) request.AddQueryParameter(Param.Before, UnixTime(before.Value));
        if (activityClass is not null) request.AddQueryParameter(Param.Class, activityClass.ToString());
        if (!string.IsNullOrWhiteSpace(deviceFilter)) request.AddQueryParameter(Param.DeviceFilter, deviceFilter);
        if (!string.IsNullOrWhiteSpace(language)) request.AddQueryParameter(Param.Language, language);
        if (newerThan is not null) request.AddQueryParameter(Param.NewerThan, newerThan.Value);
        if (olderThan is not null) request.AddQueryParameter(Param.OlderThan, olderThan.Value);
        request.AddQueryParameter(Param.PageSize, pageSize);
        if (seriesUid is not null) request.AddQueryParameter(Param.SeriesUid, seriesUid.ToString());
        if (sourceConfigUid is not null) request.AddQueryParameter(Param.SourceConfigUid, sourceConfigUid.ToString());
        if (status is not null) request.AddQueryParameter(Param.Status, status.ToString());
        if (type is not null) request.AddQueryParameter(Param.Type, type.ToString());
        if (!string.IsNullOrWhiteSpace(timeZone)) request.AddQueryParameter(Param.TimeZone, timeZone);
        if (!string.IsNullOrWhiteSpace(user)) request.AddQueryParameter(Param.User, user);

        return await GetResource<ActivityQueryResult>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getLocations
    public async Task<IList<Location>> GetLocations(int after = 0, int pageSize = DefaultMaxPageSize)
    {
        var request = new RestRequest(Resource.Locations);
        request.AddQueryParameter(Param.After, after);
        request.AddQueryParameter(Param.PageSize, pageSize);
        
        return await GetResources<Location>(request);
    }
}