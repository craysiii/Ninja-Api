namespace NinjaOne_Api.Library;

public partial class Client
{
    /// <summary>
    /// Get a list of device custom fields<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeCustomFields">getNodeCustomFields</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="withInheritance">Inherit custom fields from the device's organization and location</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceCustomFields(
    ///     deviceId: 1,
    ///     withInheritance: true
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable Dictionary with custom field key value pairs and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(Dictionary<string, JsonElement>? CustomFields, NinjaApiError? Error)> GetDeviceCustomFields(
        int deviceId, 
        bool? withInheritance = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceCustomFields, deviceId));
        if (withInheritance is not null) request.AddQueryParameter(Param.WithInheritance, withInheritance.Value);
        
        return await GetResource<Dictionary<string, JsonElement>>(request);
    }
    
    /// <summary>
    /// Update a set of custom fields for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeAttributeValues">updateNodeAttributeValues</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="fields">Hashtable containing key value pairs of the fields to update</param>
    /// <example>
    /// <code>
    /// var result = await client.UpdateDeviceCustomFields(
    ///     deviceId: 1,
    ///     new Hashtable
    ///     {
    ///         {"defaultUser", "admin"}
    ///     }
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> UpdateDeviceCustomFields(int deviceId, Hashtable fields)
    {
        var request = new RestRequest(string.Format(Resource.DeviceCustomFields, deviceId));

        return await PostResource(request, fields, Method.Patch);
    }
    
    /// <summary>
    /// Get the last logged on user for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceLastLoggedOnUser">getDeviceLastLoggedOnUser</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceLastLoggedOnUser(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="LoggedOnUser"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(LoggedOnUser? LoggedOnUser, NinjaApiError? Error)> GetDeviceLastLoggedOnUser(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceLastLoggedOnUser, deviceId));

        return await GetResource<LoggedOnUser>(request);
    }
    
    /// <summary>
    /// Get a list of pending, rejected, and approved OS Patches for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevicePendingFailedRejectedOSPatches">getDevicePendingFailedRejectedOSPatches</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="severity">Get patches of a specific severity</param>
    /// <param name="status">Get patches of a specific status</param>
    /// <param name="type">Get patches of a specific type</param>
    /// <example>
    /// <code>
    /// var patches = await client.GetDeviceOSPatches(
    ///     deviceId: 1,
    ///     status: OSPatchStatus.REJECTED,
    ///     type: OSPatchType.REGULAR_UPDATES
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="OSPatch"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<OSPatch>? OSPatches, NinjaApiError? Error)> GetDeviceOSPatches(
        int deviceId,
        OSPatchSeverity? severity = null,
        OSPatchStatus? status = null,
        OSPatchType? type = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceOSPatches, deviceId));
        if (severity is not null) request.AddQueryParameter(Param.Severity, severity.ToString());
        if (status is not null) request.AddQueryParameter(Param.Status, status.ToString());
        if (type is not null) request.AddQueryParameter(Param.Type, type.ToString());
        
        return await GetResources<OSPatch>(request);
    }
    
    /// <summary>
    /// Get list of successful and failed patches for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceInstalledOSPatches">getDeviceInstalledOSPatches</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="installedAfter">Get patches after specified date</param>
    /// <param name="installedBefore">Get patches before specified date</param>
    /// <param name="status">Get patches with a specific status</param>
    /// <example>
    /// <code>
    /// var patches = await client.GetDeviceInstalledOSPatches(
    ///     deviceId: 1129,
    ///     installedBefore: DateTime.UtcNow.AddDays(-30),
    ///     status: OSPatchInstallStatus.INSTALLED
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="OSPatchInstall"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<OSPatchInstall>? OSPatchInstalls, NinjaApiError? Error)> GetDeviceInstalledOSPatches(
        int deviceId,
        DateTime? installedAfter = null,
        DateTime? installedBefore = null,
        OSPatchInstallStatus? status = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceInstalledOSPatches, deviceId));
        if (installedAfter is not null) request.AddQueryParameter(Param.InstalledAfter, UnixTime(installedAfter.Value));
        if (installedBefore is not null) request.AddQueryParameter(Param.InstalledBefore, UnixTime(installedBefore.Value));
        if (status is not null) request.AddQueryParameter(Param.Status, status.ToString());

        return await GetResources<OSPatchInstall>(request);
    }
    
    /// <summary>
    /// Get a list of successful and failed third party software patches for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceInstalledSoftwarePatches">getDeviceInstalledSoftwarePatches</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="impact">Get software patches with a certain patch impact</param>
    /// <param name="installedAfter">Get software patches installed after specified date</param>
    /// <param name="installedBefore">Get software patches installed before specified date</param>
    /// <param name="productIdentifier">Get a specific software's patches</param>
    /// <param name="status">Get software patches of a specific status</param>
    /// <param name="type">Get software patches of a specific type</param>
    /// <example>
    /// <code>
    /// var patches = await client.GetDeviceInstalledSoftwarePatches(
    ///     deviceId: 1,
    ///     productIdentifier: new Guid("f02e197f-b2e2-4430-b813-4ead967dee56") // Google Chrome
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="SoftwarePatch"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<SoftwarePatch>? SoftwarePatches, NinjaApiError? Error)> GetDeviceInstalledSoftwarePatches(
        int deviceId,
        SoftwarePatchImpact? impact = null,
        DateTime? installedAfter = null,
        DateTime? installedBefore = null,
        Guid? productIdentifier = null,
        SoftwarePatchStatus? status = null,
        SoftwarePatchType? type = null
    )
    {
        var request = new RestRequest(string.Format(Resource.DeviceInstalledSoftwarePatches, deviceId));
        if (impact is not null) request.AddQueryParameter(Param.Impact, impact.ToString());
        if (installedAfter is not null) request.AddQueryParameter(Param.InstalledAfter, UnixTime(installedAfter.Value));
        if (installedBefore is not null) request.AddQueryParameter(Param.InstalledBefore, UnixTime(installedBefore.Value));
        if (productIdentifier is not null) request.AddQueryParameter(Param.ProductIdentifier, productIdentifier.ToString());
        if (status is not null) request.AddQueryParameter(Param.Status, status.ToString());
        if (type is not null) request.AddQueryParameter(Param.Type, type.ToString());

        return await GetResources<SoftwarePatch>(request);
    }
    
    /// <summary>
    /// Get a list of network interfaces for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceNetworkInterfaces">getDeviceNetworkInterfaces</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceNetworkInterfaces(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="DeviceNetworkInterface"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<DeviceNetworkInterface>? DeviceNetworkInterfaces, NinjaApiError? Error)> 
        GetDeviceNetworkInterfaces(
            int deviceId
            )
    {
        var request = new RestRequest(string.Format(Resource.DeviceNetworkInterfaces, deviceId));
    
        return await GetResources<DeviceNetworkInterface>(request);
    }
    
    /// <summary>
    /// Get a list of disk drives for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceDiskDrives">getDeviceDiskDrives</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceDiskDrives(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="DiskDrive"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<DiskDrive>? DiskDrives, NinjaApiError? Error)> GetDeviceDiskDrives(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceDiskDrives, deviceId));

        return await GetResources<DiskDrive>(request);
    }

    /// <summary>
    /// Get a list of storage volumes for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceVolumes">getDeviceVolumes</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="include">Additional information to include ("bl" - Bitlocker Status)</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceVolumes(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="DeviceVolume"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<DeviceVolume>? DeviceVolumes, NinjaApiError? Error)> GetDeviceVolumes(
        int deviceId, 
        string? include = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceVolumes, deviceId));
        if (!string.IsNullOrWhiteSpace(include)) request.AddQueryParameter(Param.Include, include);

        return await GetResources<DeviceVolume>(request);
    }
    
    /// <summary>
    /// Get a list of processors for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceProcessors">getDeviceProcessors</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceProcessors(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Processor"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Processor>? Processors, NinjaApiError? Error)> GetDeviceProcessors(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceProcessors, deviceId));

        return await GetResources<Processor>(request);
    }
    
    /// <summary>
    /// Get a list of installed software for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceSoftware">getDeviceSoftware</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceSoftwareInventory(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="SoftwareInstallation"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<SoftwareInstallation>? SoftwareInstallations, NinjaApiError? Error)>
        GetDeviceSoftwareInventory(
            int deviceId
            )
    {
        var request = new RestRequest(string.Format(Resource.DeviceSoftwareInventory, deviceId));

        return await GetResources<SoftwareInstallation>(request);
    }
    
    /// <summary>
    /// Get a list of active alerts for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceAlerts">getDeviceAlerts</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="language"><a href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">See ISO 639 Language Codes</a></param>
    /// <param name="timeZone"><a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">See Timezone Identifiers</a></param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceAlerts(
    ///     deviceId: 1,
    ///     language: "fr" // French
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Alert"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Alert>? Alerts, NinjaApiError? Error)> GetDeviceAlerts(
        int deviceId, 
        string? language = null, 
        string? timeZone = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceAlerts, deviceId));
        if (language is not null) request.AddQueryParameter(Param.Language, language);
        if (timeZone is not null) request.AddQueryParameter(Param.TimeZone, timeZone);

        return await GetResources<Alert>(request);
    }
    
    /// <summary>
    /// Get a list of running jobs for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceActiveJobs">getDeviceActiveJobs</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="language"><a href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">See ISO 639 Language Codes</a></param>
    /// <param name="timeZone"><a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">See Timezone Identifiers</a></param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceActiveJobs(
    ///     deviceId: 1,
    ///     language: "es" // Spanish
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="Job"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<Job>? DeviceActiveJobs, NinjaApiError? Error)> GetDeviceActiveJobs(
        int deviceId, 
        string? language = null, 
        string? timeZone = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceActiveJobs, deviceId));
        if (language is not null) request.AddQueryParameter(Param.Language, language);
        if (timeZone is not null) request.AddQueryParameter(Param.TimeZone, timeZone);

        return await GetResources<Job>(request);
    }
    
    /// <summary>
    /// Get a list of Windows services for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceServices">getDeviceServices</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="name">Get a specific service</param>
    /// <param name="state">Get services with a specific state</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceWindowsServices(
    ///     deviceId: 1,
    ///     state: ServiceState.RUNNING
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="WindowsService"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<WindowsService>? WindowsServices, NinjaApiError? Error)> GetDeviceWindowsServices(
        int deviceId,
        string? name = null,
        ServiceState? state = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceWindowsServices, deviceId));
        if (!string.IsNullOrWhiteSpace(name)) request.AddQueryParameter(Param.Name, name);
        if (state is not null) request.AddQueryParameter(Param.State, state.ToString());

        return await GetResources<WindowsService>(request);
    }
    
    /// <summary>
    /// Get a list of policy overrides for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getPolicyOverrides">getPolicyOverrides</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDevicePolicyOverrides(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="DevicePolicyOverrides"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(DevicePolicyOverrides? DevicePolicyOverrides, NinjaApiError? Error)> GetDevicePolicyOverrides(
        int deviceId
        )
    {
        var request = new RestRequest(string.Format(Resource.DevicePolicyOverrides, deviceId));

        return await GetResource<DevicePolicyOverrides>(request);
    }
    
    /// <summary>
    /// Get a list of activities for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceActivities">getDeviceActivities</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="activityType">Get activities of a certain type</param>
    /// <param name="language"><a href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">See ISO 639 Language Codes</a></param>
    /// <param name="newerThan">Get activities that are newer than specified activity Id</param>
    /// <param name="olderThan">Get activities that are older than specified activity Id</param>
    /// <param name="pageSize">Maximum number of activities to return in a single request. Defaults to 1000</param>
    /// <param name="seriesUid">Get activities related to alert (series)</param>
    /// <param name="status">Get activities with a specific status</param>
    /// <param name="timeZone"><a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">See Timezone Identifiers</a></param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceActivities(
    ///     deviceId: 1,
    ///     activityType: ActivityType.NINJA_REMOTE
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="DeviceActivityResult"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(DeviceActivityResult? DeviceActivityResult, NinjaApiError? Error)> GetDeviceActivities(
        int deviceId,
        ActivityType? activityType = null,
        string? language = null,
        int? newerThan = null,
        int? olderThan = null,
        int pageSize = DefaultMaxPageSize,
        Guid? seriesUid = null,
        StatusCode? status = null,
        string? timeZone = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceActivities, deviceId));
        if (activityType is not null) request.AddQueryParameter(Param.ActivityType, activityType.ToString());
        if (!string.IsNullOrWhiteSpace(language)) request.AddQueryParameter(Param.Language, language);
        if (newerThan is not null) request.AddQueryParameter(Param.NewerThan, newerThan.Value);
        if (olderThan is not null) request.AddQueryParameter(Param.OlderThan, olderThan.Value);
        request.AddQueryParameter(Param.PageSize, pageSize);
        if (seriesUid is not null) request.AddQueryParameter(Param.SeriesUid, seriesUid.ToString());
        if (status is not null) request.AddQueryParameter(Param.Status, status.ToString());
        if (timeZone is not null) request.AddQueryParameter(Param.TimeZone, timeZone);

        return await GetResource<DeviceActivityResult>(request);
    }
    
    /// <summary>
    /// Get a specific device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevice">getDevice</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDevice(
    ///     deviceId: 1
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="Device"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(Device? Device, NinjaApiError? Error)> GetDevice(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.Device, deviceId));

        return await GetResource<Device>(request);
    }
    
    /// <summary>
    /// Get a list of third party software patches for a device<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevicePendingFailedRejectedSoftwarePatches">getDevicePendingFailedRejectedSoftwarePatches</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="impact">Get patches with a certain impact</param>
    /// <param name="productIdentifier">Get a specific software's patches</param>
    /// <param name="status">Get patches with a certain status</param>
    /// <param name="type">Get patches of a certain type</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDeviceSoftwarePatchStatus(
    ///     deviceId: 1,
    ///     productIdentifier: new Guid("f02e197f-b2e2-4430-b813-4ead967dee56"), // Google Chrome
    ///     status: SoftwarePatchStatus.FAILED
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of <see cref="SoftwarePatch"/> and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<SoftwarePatch>? SoftwarePatches, NinjaApiError? Error)> GetDeviceSoftwarePatchStatus(
        int deviceId,
        SoftwarePatchImpact? impact = null,
        Guid? productIdentifier = null,
        SoftwarePatchStatus? status = null,
        SoftwarePatchType? type = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceSoftwarePatchStatus, deviceId));
        if (impact is not null) request.AddQueryParameter(Param.Impact, impact.ToString());
        if (productIdentifier is not null) request.AddQueryParameter(Param.ProductIdentifier, productIdentifier.ToString());
        if (status is not null) request.AddQueryParameter(Param.Status, status.ToString());
        if (type is not null) request.AddQueryParameter(Param.Type, type.ToString());

        return await GetResources<SoftwarePatch>(request);
    }
}