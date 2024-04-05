namespace NinjaOne_Api.Library;

public partial class Client
{
    /// <summary>
    /// Get a list of organizations<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizations">getOrganizations</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="after">Id of the last organization from the previous page</param>
    /// <param name="pageSize">Maximum number of organizations to return in a single request. Defaults to 1000</param>
    /// <example>
    /// <code>
    /// var result = await client.GetOrganizations(
    ///     after: 1000
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="OrganizationBase"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<OrganizationBase>? Organizations, NinjaApiError? Error)> GetOrganizations(
        int after = 0, 
        int pageSize = DefaultMaxPageSize
        )
    {
        var request = new RestRequest(Resource.Organizations);
        request.AddQueryParameter(Param.After, after);
        request.AddQueryParameter(Param.PageSize, pageSize);
        
        return await GetResources<OrganizationBase>(request);
    }
    
    /// <summary>
    /// Search for a list of devices<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/search">search</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="query">Query string to use for search</param>
    /// <param name="limit">Maximum number of devices to return</param>
    /// <example>
    /// <code>
    /// var result = await client.QueryDevices(
    ///     query: "192.168.1.10"
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="DeviceQuery"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(DeviceQuery? Devices, NinjaApiError? Error)> QueryDevices(string query, int limit = int.MaxValue)
    {
        var request = new RestRequest(Resource.DeviceSearch);
        request.AddQueryParameter(Param.Query, query);
        request.AddQueryParameter(Param.Limit, limit);
        
        return await GetResource<DeviceQuery>(request);
    }
    
    /// <summary>
    /// Get a list of all device custom fields<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceGlobalCustomFields">getDeviceGlobalCustomFields</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceGlobalCustomFields();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="DeviceCustomField"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<DeviceCustomField>? CustomFields, NinjaApiError? Error)> GetGlobalDeviceCustomFields()
    {
        var request = new RestRequest(Resource.CustomFieldDefinitions);
        
        return await GetResources<DeviceCustomField>(request);
    }
    
    /// <summary>
    /// Get a list of all policies<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getPolicies">getPolicies</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <example>
    /// <code>
    /// var result = await client.GetPolicies();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Policy"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Policy>? Policies, NinjaApiError? Error)> GetPolicies()
    {
        var request = new RestRequest(Resource.Policies);
        
        return await GetResources<Policy>(request);
    }
    
    /// <summary>
    /// Get a list of active alerts<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getAlerts">getAlerts</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceFilter"><a href="https://app.ninjarmm.com/apidocs-beta/core-resources/articles/devices/device-filters">Device Filters</a></param>
    /// <param name="language"><a href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">See ISO 639 Language Codes</a></param>
    /// <param name="sourceType">Get a specific alert source type</param>
    /// <param name="timeZone"><a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">See Timezone Identifiers</a></param>
    /// <example>
    /// <code>
    /// var alerts = await client.GetAlerts(
    ///     sourceType: SourceType.AGENT_OFFLINE
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Alert"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Alert>? Alerts, NinjaApiError? Error)> GetAlerts(
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
    
    /// <summary>
    /// Get a list of detailed organizations<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOrganizationsDetailed">getOrganizationsDetailed</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="after">Id of the last organization from the previous page</param>
    /// <param name="pageSize">Maximum number of organizations to return</param>
    /// <example>
    /// <code>
    /// var result = await client.GetOrganizationsDetailed();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Organization"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Organization>? Organizations, NinjaApiError? Error)> GetOrganizationsDetailed(
        int after = 0, 
        int pageSize = DefaultMaxPageSize
        )
    {
        var request = new RestRequest(Resource.OrganizationsDetailed);
        request.AddQueryParameter(Param.After, after);
        request.AddQueryParameter(Param.PageSize, pageSize);
        
        var result = await GetResources<Organization>(request);
        
        if (result.Resources is null || result.Resources.Count == 0) return result;
        
        foreach (var org in result.Resources)
        {
            foreach (var location in org.Locations!)
            {
                location.OrganizationId = org.Id;
            }
        }

        return result;
    }
    
    /// <summary>
    /// Get a list of all device roles<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeRoles">getNodeRoles</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceRoles();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="DeviceRole"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<DeviceRole>? DeviceRoles, NinjaApiError? Error)> GetDeviceRoles()
    {
        var request = new RestRequest(Resource.Roles);
        
        return await GetResources<DeviceRole>(request);
    }
    
    /// <summary>
    /// Get a list of supported 3rd party software<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getSoftwareProducts">getSoftwareProducts</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <example>
    /// <code>
    /// var result = await client.GetSoftwareProducts();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="SoftwareProduct"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<SoftwareProduct>? SoftwareProducts, NinjaApiError? Error)> GetSoftwareProducts()
    {
        var request = new RestRequest(Resource.SoftwareProducts);
        
        return await GetResources<SoftwareProduct>(request);
    }
    
    /// <summary>
    /// Get a list of detailed devices><br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevicesDetailed">getDevicesDetailed</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceFilter"><a href="https://app.ninjarmm.com/apidocs-beta/core-resources/articles/devices/device-filters">Device Filters</a></param>
    /// <param name="after">Id of the last device from the previous page</param>
    /// <param name="pageSize">Maximum number of devices to return</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDevicesDetailed(
    ///     deviceFilter: "org = 1"
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Device"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Device>? Devices, NinjaApiError? Error)> GetDevicesDetailed(
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
    /// <summary>
    /// Get a list of running jobs<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getActiveJobs">getActiveJobs</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceFilter"><a href="https://app.ninjarmm.com/apidocs-beta/core-resources/articles/devices/device-filters">Device Filters</a></param>
    /// <param name="language"><a href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">See ISO 639 Language Codes</a></param>
    /// <param name="jobType">Get a specific job source type</param>
    /// <param name="timeZone"><a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">See Timezone Identifiers</a></param>
    /// <example>
    /// <code>
    /// var jobs = await client.GetActiveJobs(
    ///     jobType: JobType.CONDITION_ACTIONSET
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Job"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Job>? Jobs, NinjaApiError? Error)> GetActiveJobs(
        string? deviceFilter = null,
        string? language = null,
        JobType? jobType = null,
        string? timeZone = null
        )
    {
        var request = new RestRequest(Resource.Jobs);
        if (!string.IsNullOrWhiteSpace(deviceFilter)) request.AddQueryParameter(Param.DeviceFilter, deviceFilter);
        if (!string.IsNullOrWhiteSpace(language)) request.AddQueryParameter(Param.Language, language);
        if (jobType is not null) request.AddQueryParameter(Param.JobType, jobType.Value.ToString());
        if (!string.IsNullOrWhiteSpace(timeZone)) request.AddQueryParameter(Param.TimeZone, timeZone);
        
        return await GetResources<Job>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getScheduledTasks
    /// <summary>
    /// Get a list of scheduled tasks<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getScheduledTasks">getScheduledTasks</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <example>
    /// <code>
    /// var result = await client.GetScheduledTasks();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="ScheduledTask"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<ScheduledTask>? ScheduledTasks, NinjaApiError? Error)> GetScheduledTasks()
    {
        var request = new RestRequest(Resource.Tasks);
        
        return await GetResources<ScheduledTask>(request);
    }
    
    /// <summary>
    /// Get a list of users<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getUsers">getUsers</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <example>
    /// <code>
    /// var result = await client.GetUsers();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="User"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<User>? Users, NinjaApiError? Error)> GetUsers()
    {
        var request = new RestRequest(Resource.Users);
        
        return await GetResources<User>(request);
    }
    
    /// <summary>
    /// Get a list of groups<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getGroups">getGroups</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <example>
    /// <code>
    /// var result = await client.GetGroups();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Group"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Group>? Groups, NinjaApiError? Error)> GetGroups()
    {
        var request = new RestRequest(Resource.Groups);
        
        return await GetResources<Group>(request);
    }
    
    /// <summary>
    /// Get a list of devices<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevices">getDevices</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceFilter"><a href="https://app.ninjarmm.com/apidocs-beta/core-resources/articles/devices/device-filters">Device Filters</a></param>
    /// <param name="after">Id of the last devices from the previous page</param>
    /// <param name="pageSize">Maximum number of devices to return in a single request. Defaults to 1000</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDevices(
    ///     deviceFilter: "org = 1"
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="DeviceBase"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<DeviceBase>? Devices, NinjaApiError? Error)> GetDevices(
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
    
    /// <summary>
    /// Get a list of activities<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getActivities">getActivities</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="after">Get activities recorded after to specified DateTime</param>
    /// <param name="before">Get activities recorded prior to specified DateTime</param>
    /// <param name="activityClass">Get activities related to a specific activity class. Default is ActivityClass.ALL</param>
    /// <param name="deviceFilter"><a href="https://app.ninjarmm.com/apidocs-beta/core-resources/articles/devices/device-filters">Device Filters</a></param>
    /// <param name="language"><a href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">See ISO 639 Language Codes</a></param>
    /// <param name="newerThan">Get activities that are newer than specified activity Id</param>
    /// <param name="olderThan">Get activities that are older than specified activity Id</param>
    /// <param name="pageSize">Maximum number of activities to return in a single request. Defaults to 1000</param>
    /// <param name="seriesUid">Get activities related to alert (series)</param>
    /// <param name="sourceConfigUid">Get activities related to a specific script</param>
    /// <param name="status">Get activities with a specific status</param>
    /// <param name="type">Get activities of a specific type</param>
    /// <param name="timeZone"><a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">See Timezone Identifiers</a></param>
    /// <param name="userId">Get activities for a specific user by Id</param>
    /// <example>
    /// <code>
    /// var res = await client.GetActivities(
    ///     before: DateTime.UtcNow.AddDays(-10),
    ///     status: StatusCode.USER_LOGGED_IN
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="ActivityQueryResult"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(ActivityQueryResult? ActivityQueryResult, NinjaApiError? Error)> GetActivities(
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
        int? userId = null
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
        if (userId is not null) request.AddQueryParameter(Param.User, userId.Value);

        return await GetResource<ActivityQueryResult>(request);
    }
    
    /// <summary>
    /// Get a list of locations<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getLocations">getLocations</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="after">Id of the last location from the previous page</param>
    /// <param name="pageSize">Maximum number of locations to return in a single request. Defaults to 1000</param>
    /// <example>
    /// <code>
    /// var result = await client.GetLocations(
    ///     after: 1000
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Location"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Location>? Locations, NinjaApiError? Error)> GetLocations(
        int after = 0, 
        int pageSize = DefaultMaxPageSize
        )
    {
        var request = new RestRequest(Resource.Locations);
        request.AddQueryParameter(Param.After, after);
        request.AddQueryParameter(Param.PageSize, pageSize);
        
        return await GetResources<Location>(request);
    }
    
    /// <summary>
    /// Get a list of automation scripts<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getAutomationScripts">getAutomationScripts</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="language">Get automations scripts of a certain scripting language</param>
    /// <example>
    /// <code>
    /// var scripts = await client.GetAutomationScripts(
    ///     language: "powershell"
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="AutomationScript"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<AutomationScript>? AutomationScripts, NinjaApiError? Error)> GetAutomationScripts(
        string? language = null
    )
    {
        var request = new RestRequest(Resource.AutomationScripts);
        if (!string.IsNullOrWhiteSpace(language)) request.AddQueryParameter(Param.Language, language);

        return await GetResources<AutomationScript>(request);
    }
    
    /// <summary>
    /// Get a list of notification channels<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNotificationChannels">getNotificationChannels</a>
    /// on Ninja One Public API Reference<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getEnabledNotificationChannels">getEnabledNotificationChannels</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="enabled">Get only enabled notification channels</param>
    /// <example>
    /// <code>
    /// var result = await client.GetNotificationChannels();
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="NotificationChannel"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<NotificationChannel>? NotificationChannels, NinjaApiError? Error)> GetNotificationChannels(
        bool enabled = false
        )
    {
        var request = new RestRequest(enabled ? Resource.EnabledNotificationChannels : Resource.NotificationChannels);

        return await GetResources<NotificationChannel>(request);
    }
}