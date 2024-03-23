namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/resetAlertSetActivityData
    // TODO: Implement ResetAlertWithCustomData
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/nodeApprovalOperation
    // TODO: Implement ApproveOrRejectDevices
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/createOrganization
    // TODO: Implement CreateOrganization
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/resetAlert
    // TODO: Implement ResetAlert
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/setWindowsServiceConfiguration
    // TODO: Implement SetDeviceWindowsServiceConfiguration
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getDeviceLink
    // TODO: Implement GetDeviceLink
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/resetPolicyOverrides
    // TODO: Implement ResetDevicePolicyOverrides
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/requestScriptingOptions
    // TODO: Implement GetDeviceScriptionOptions
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/controlWindowsService
    // TODO: Implement SetDeviceWindowsService
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/rebootDevices
    // TODO: Implement RebootDevice
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateDeviceMaintenance
    // TODO: Implement UpdateDeviceMaintenance
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/cancelDeviceMaintenance
    // TODO: Implement CancelDeviceMaintenance
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/runScriptOnDevice
    // TODO: Implement RunDeviceScript
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateDevice
    // TODO: Implement UpdateDevice
    public async Task<(bool Success, NinjaApiError? Error)> UpdateDevice(int deviceId, Hashtable updateParameters)
    {
        var request = new RestRequest(string.Format(Resource.Device, deviceId));

        return await PostResource(request, updateParameters, Method.Patch);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateOrganization
    // TODO: Implement UpdateOrganization
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/createLocationForOrganization
    // TODO: Implement CreateOrganizationLocation
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getInstallerForLocation
    // TODO: Implement GetOrganizationLocationInstaller
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getInstaller
    // TODO: Account for custom installers
    public async Task<(Installer? Installer, NinjaApiError? Error)> CreateOrganizationLocationInstaller(
        int organizationId,
        int locationId,
        InstallerType installerType
        )
    {
        var installer = new
        {
            organizationId, locationId, installerType = installerType.ToString(), content = new {}
        };

        var request = new RestRequest(Resource.GenerateInstaller);

        return await PostResource<Installer>(request, installer);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateLocation
    // TODO: Implement UpdateLocation
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateNodeRolePolicyAssignmentForOrganization
    // TODO: Implement UpdateOrganizationPolicyAssignments
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/createPolicy
    // TODO: Implement CreatePolicy
}