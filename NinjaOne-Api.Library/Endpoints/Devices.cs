namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNodeCustomFields
    public async Task<IDictionary<string, JsonElement>> GetDeviceCustomFields(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceCustomFields, deviceId));

        return await GetResource<IDictionary<string, JsonElement>>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeAttributeValues
    public async Task<bool> UpdateDeviceCustomFields(int deviceId, Hashtable fields)
    {
        var request = new RestRequest(string.Format(Resource.DeviceCustomFields, deviceId));

        return await PostResource(request, fields, Method.Patch);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceLastLoggedOnUser
    public async Task<LoggedOnUser> GetDeviceLastLoggedOnUser(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceLastLoggedOnUser, deviceId));

        return await GetResource<LoggedOnUser>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevicePendingFailedRejectedOSPatches
    public async Task<IList<OSPatch>> GetDeviceOSPatches(
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
    public async Task<IList<OSPatchInstall>> GetDeviceInstalledOSPatches(
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
    // TODO: Implement GetDeviceInstalledSoftwarePatches

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceNetworkInterfaces
    // TODO: Implement after Ninja fixes inconsistent serialization mentioned in DeviceNetworkInterface class
    // public async Task<IList<DeviceNetworkInterface>> GetDeviceNetworkInterfaces(int deviceId)
    // {
    //     var request = new RestRequest(string.Format("device/{0}/network-interfaces", deviceId));
    //
    //     return await GetResources<DeviceNetworkInterface>(request);
    // }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceDiskDrives
    public async Task<IList<DiskDrive>> GetDeviceDiskDrives(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceDiskDrives, deviceId));

        return await GetResources<DiskDrive>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceVolumes
    // TODO: Implement GetDeviceVolumes
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceProcessors
    public async Task<IList<Processor>> GetDeviceProcessors(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceProcessors, deviceId));

        return await GetResources<Processor>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceSoftware
    public async Task<IList<SoftwareInstallation>> GetDeviceSoftwareInventory(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceSoftwareInventory, deviceId));

        return await GetResources<SoftwareInstallation>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceAlerts
    // TODO: Implement GetDeviceAlerts
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceActiveJobs
    // TODO: Implement GetDeviceActiveJobs

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceServices
    public async Task<IList<WindowsService>> GetDeviceWindowsServices(
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
    public async Task<DevicePolicyOverrides> GetDevicePolicyOverrides(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DevicePolicyOverrides, deviceId));

        return await GetResource<DevicePolicyOverrides>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceActivities
    public async Task<DeviceActivityResult> GetDeviceActivities(
        int deviceId,
        ActivityType? activityType = null,
        string? lang = null,
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
        if (!string.IsNullOrWhiteSpace(lang)) request.AddQueryParameter(Param.Language, lang);
        if (newerThan is not null) request.AddQueryParameter(Param.NewerThan, newerThan.Value);
        if (olderThan is not null) request.AddQueryParameter(Param.OlderThan, olderThan.Value);
        request.AddQueryParameter(Param.PageSize, pageSize);
        if (seriesUid is not null) request.AddQueryParameter(Param.SeriesUid, seriesUid.ToString());
        if (status is not null) request.AddQueryParameter(Param.Status, status.ToString());
        if (timeZone is not null) request.AddQueryParameter(Param.TimeZone, timeZone);

        return await GetResource<DeviceActivityResult>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevice
    public async Task<Device> GetDevice(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.Device, deviceId));

        return await GetResource<Device>(request);
    }

    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDevicePendingFailedRejectedSoftwarePatches
    public async Task<IList<SoftwarePatchStatus>> GetDeviceSoftwarePatchStatus(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceSoftwarePatchStatus, deviceId));

        return await GetResources<SoftwarePatchStatus>(request);
    }
}