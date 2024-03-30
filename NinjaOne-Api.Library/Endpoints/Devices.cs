namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeCustomFields
    public async Task<(Dictionary<string, JsonElement>? CustomFields, NinjaApiError? Error)> GetDeviceCustomFields(
        int deviceId, 
        bool? withInheritance = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceCustomFields, deviceId));
        if (withInheritance is not null) request.AddQueryParameter(Param.WithInheritance, withInheritance.Value);
        
        return await GetResource<Dictionary<string, JsonElement>>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeAttributeValues
    public async Task<(bool Success, NinjaApiError? Error)> UpdateDeviceCustomFields(int deviceId, Hashtable fields)
    {
        var request = new RestRequest(string.Format(Resource.DeviceCustomFields, deviceId));

        return await PostResource(request, fields, Method.Patch);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceLastLoggedOnUser
    public async Task<(LoggedOnUser? LoggedOnUser, NinjaApiError? Error)> GetDeviceLastLoggedOnUser(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceLastLoggedOnUser, deviceId));

        return await GetResource<LoggedOnUser>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevicePendingFailedRejectedOSPatches
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

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceInstalledOSPatches
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
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceInstalledSoftwarePatches
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

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceNetworkInterfaces
    public async Task<(List<DeviceNetworkInterface>? DeviceNetworkInterfaces, NinjaApiError? Error)> 
        GetDeviceNetworkInterfaces(
            int deviceId
            )
    {
        var request = new RestRequest(string.Format(Resource.DeviceNetworkInterfaces, deviceId));
    
        return await GetResources<DeviceNetworkInterface>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceDiskDrives
    public async Task<(List<DiskDrive>? DiskDrives, NinjaApiError? Error)> GetDeviceDiskDrives(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceDiskDrives, deviceId));

        return await GetResources<DiskDrive>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceVolumes
    public async Task<(List<DeviceVolume>? DeviceVolumes, NinjaApiError? Error)> GetDeviceVolumes(
        int deviceId, 
        string? include = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceVolumes, deviceId));
        if (!string.IsNullOrWhiteSpace(include)) request.AddQueryParameter(Param.Include, include);

        return await GetResources<DeviceVolume>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceProcessors
    public async Task<(List<Processor>? Processors, NinjaApiError? Error)> GetDeviceProcessors(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceProcessors, deviceId));

        return await GetResources<Processor>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceSoftware
    public async Task<(List<SoftwareInstallation>? SoftwareInstallations, NinjaApiError? Error)>
        GetDeviceSoftwareInventory(
            int deviceId
            )
    {
        var request = new RestRequest(string.Format(Resource.DeviceSoftwareInventory, deviceId));

        return await GetResources<SoftwareInstallation>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceAlerts
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
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceActiveJobs
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

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceServices
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

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getPolicyOverrides
    public async Task<(DevicePolicyOverrides? DevicePolicyOverrides, NinjaApiError? Error)> GetDevicePolicyOverrides(
        int deviceId
        )
    {
        var request = new RestRequest(string.Format(Resource.DevicePolicyOverrides, deviceId));

        return await GetResource<DevicePolicyOverrides>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceActivities
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

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevice
    public async Task<(Device? Device, NinjaApiError? Error)> GetDevice(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.Device, deviceId));

        return await GetResource<Device>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevicePendingFailedRejectedSoftwarePatches
    public async Task<(List<SoftwarePatch>? SoftwarePatches, NinjaApiError? Error)> GetDeviceSoftwarePatchStatus(
        int deviceId,
        SoftwarePatchImpact? impact = null,
        string? productIdentifier = null,
        SoftwarePatchStatus? status = null,
        SoftwarePatchType? type = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceSoftwarePatchStatus, deviceId));
        if (impact is not null) request.AddQueryParameter(Param.Impact, impact.ToString());
        if (!string.IsNullOrWhiteSpace(productIdentifier))
            request.AddQueryParameter(Param.ProductIdentifier, productIdentifier);
        if (status is not null) request.AddQueryParameter(Param.Status, status.ToString());
        if (type is not null) request.AddQueryParameter(Param.Type, type.ToString());

        return await GetResources<SoftwarePatch>(request);
    }
}