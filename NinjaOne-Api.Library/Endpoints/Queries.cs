namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getNetworkInterfaces
    public async Task<NetworkInterfaceQuery> QueryNetworkInterfaces(
        string? cursor = null,
        string? deviceFilter = null,
        int pageSize = DefaultMaxPageSize
        )
    {
        var request = new RestRequest(Resource.QueriesNetworkInterface);
        if (!string.IsNullOrWhiteSpace(cursor)) request.AddQueryParameter(Param.Cursor, cursor);
        if (!string.IsNullOrWhiteSpace(deviceFilter)) request.AddQueryParameter(Param.DeviceFilter, deviceFilter);
        request.AddQueryParameter(Param.PageSize, pageSize);

        return await GetResource<NetworkInterfaceQuery>(request);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getPendingFailedRejectedOSPatches
    // TODO: Implement GetOSPatches
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getPendingFailedRejectedSoftwarePatches
    // TODO: Implement GetSoftwarePatches
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getInstalledSoftwarePatches
    // TODO: Implement GetInstalledSoftwarePatches
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getLastLoggedOnUsersReport
    // TODO: Implement GetLastLoggedOnUsers
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getCustomFieldsDetailedReport
    // TODO: Implement GetCustomFieldsDetailedReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getScopedCustomFieldsReport
    // TODO: Implement GetScopedCustomFieldsReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getScopedCustomFieldsDetailedReport
    // TODO: Implement GetScopedCustomFIeldsDetailedReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getComputerSystems
    // TODO: Implement GetComputerSystems
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDiskDrives
    // TODO: Implement GetDiskDrives
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceHealthReport
    // TODO: Implement GetDeviceHealthReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getSoftware
    // TODO: Implement GetSoftwareInventory
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getInstalledOSPatches
    // TODO: Implement GetInstalledOSPatches
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getAntivirusStatusReport
    // TODO: Implement GetAntivirusStatusReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getRAIDControllerReport
    // TODO: Implement GetRAIDControllerReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getRAIDDriveReport
    // TODO: Implement GetRAIDDriveReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getWindowsServicesReport
    // TODO: Implement GetWindowsServicesReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getCustomFieldsReport
    // TODO: GetCustomFieldsReport
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getPolicyOverrides_1
    // TODO: GetPolicyOverrides
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceUsage
    // TODO: GetDeviceBackupUsage
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getOperatingSystems
    // TODO: GetOperatingSystems
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getProcessors
    // TODO: GetProcessors
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getVolumes
    // TODO: GetDiskVolumes
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getAntivirusThreats
    // TODO: GetAntivirusThreats
}