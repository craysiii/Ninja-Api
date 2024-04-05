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
    
    /// <summary>
    /// Start, Stop, Pause, or Restart a Windows Service on a device.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/controlWindowsService">controlWindowsService</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device</param>
    /// <param name="serviceName">Name of the Windows Service</param>
    /// <param name="action">What action to take upon the Windows Service</param>
    /// <example>
    /// <code>
    /// var result = await client.SetDeviceWindowsService(
    ///     deviceId: 1,
    ///     serviceName: "NinjaRMMAgent",
    ///     action: ServiceAction.RESTART
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> SetDeviceWindowsService(
        int deviceId,
        string serviceName,
        ServiceAction action
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceWindowsServiceControl, deviceId, serviceName));
        var serviceAction = new
        {
            action
        };

        return await PostResource(request, serviceAction);
    }
    
    /// <summary>
    /// Reboot a device.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/rebootDevices">rebootDevices</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the device to reboot</param>
    /// <param name="rebootMode">Enum designating whether normal or forced reboot</param>
    /// <param name="reason">Optional provided reason for reboot</param>
    /// <example>
    /// <code>
    /// var result = await client.RebootDevice(
    ///     deviceId: 1,
    ///     rebootMode: RebootMode.FORCED,
    ///     reason: "Sunday Night Reboot"
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> RebootDevice(
        int deviceId,
        RebootMode rebootMode,
        string? reason = null
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceReboot, deviceId, rebootMode.ToString()));

        var rebootReason = new
        {
            reason = reason ?? string.Empty
        };

        return await PostResource(request, rebootReason);
    }
    
    /// <summary>
    /// Set or update a device's maintenance window.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateDeviceMaintenance">updateDeviceMaintenance</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <remarks>DateTime values should be in UTC</remarks>
    /// <param name="deviceId">Id of the device to schedule a maintenance window for</param>
    /// <param name="start"><c>DateTime</c> indicating the start of the maintenance window</param>
    /// <param name="end"><c>DateTime</c> indicating the end of the maintenance window</param>
    /// <param name="disabledFeatures">Multi-flag enum designating which features to disable during the maintenance window</param>
    /// <example>
    /// <code>
    /// var result = await client.UpdateDeviceMaintenance(
    ///     deviceId: 1,
    ///     start: DateTime.UtcNow.AddSeconds(5),
    ///     end: DateTime.UtcNow.AddMinutes(30),
    ///     disabledFeatures: MaintenanceFeatures.TASKS | MaintenanceFeatures.ALERTS
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> UpdateDeviceMaintenance(
        int deviceId,
        DateTime start,
        DateTime end,
        MaintenanceFeatures disabledFeatures
        )
    {
        var request = new RestRequest(string.Format(Resource.DeviceMaintenance, deviceId));

        var maintenance = new
        {
            start = UnixTime(start), end = UnixTime(end), disabledFeatures = disabledFeatures.ToString().Split(',')
        };

        return await PostResource(request, maintenance, Method.Put);
    }
    
    /// <summary>
    /// Cancel a device's maintenance window.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/cancelDeviceMaintenance">cancelDeviceMaintenance</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the Device to cancel a maintenance for</param>
    /// <example>
    /// <code>
    /// var result = await client.CancelDeviceMaintenance(deviceId: 1);
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> CancelDeviceMaintenance(int deviceId)
    {
        var request = new RestRequest(string.Format(Resource.DeviceMaintenance, deviceId));

        return await PostResource(request, null, Method.Delete);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/runScriptOnDevice
    // TODO: Implement RunDeviceScript
    
    /// <summary>
    /// Update modifiable properties for a Device.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateDevice">updateDevice</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="deviceId">Id of the Device to update</param>
    /// <param name="updateParameters">A <c>Hashtable</c> containing the fields to be updated</param>
    /// <example>
    /// <code>
    /// var response = await client.UpdateDevice(deviceId: 1, new Hashtable
    /// {
    ///    { "displayName", "First Device"}
    /// });
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> UpdateDevice(int deviceId, Hashtable updateParameters)
    {
        var request = new RestRequest(string.Format(Resource.Device, deviceId));

        return await PostResource(request, updateParameters, Method.Patch);
    }

    /// <summary>
    /// Update modifiable properties for a Device.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateDevice">updateDevice</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="device">The <c>DeviceBase</c> instance to derive the device Id and updated fields from</param>
    /// <example>
    /// <code>
    /// var result = await client.GetDevice(100);
    /// result.Device!.DisplayName = "Important Server";
    /// var response = await client.UpdateDevice(result.Device);
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> UpdateDevice(DeviceBase device)
    {
        var request = new RestRequest(string.Format(Resource.Device, device.Id));

        return await PostResource(request, device.UpdateDeviceDto(), Method.Patch);
    }
    
    /// <summary>
    /// Update modifiable properties for an Organization.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateOrganization">updateOrganization</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the Organization to update</param>
    /// <param name="updateParameters">A <c>Hashtable</c> containing the fields to be updated</param>
    /// <example>
    /// <code>
    /// var response = await client.UpdateOrganization(organizationId: 1, new Hashtable
    /// {
    ///    { "name", "Organization X"}
    /// });
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> UpdateOrganization(
        int organizationId,
        Hashtable updateParameters
    )
    {
        var request = new RestRequest(string.Format(Resource.Organization, organizationId));

        return await PostResource(request, updateParameters, Method.Patch);
    }

    /// <summary>
    /// Update modifiable properties for an Organization.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/updateOrganization">updateOrganization</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organization">The <c>OrganizationBase</c> instance to derive the organization Id and updated fields from</param>
    /// <example>
    /// <code>
    /// var result = await client.GetOrganization(1);
    /// result.Organization!.Name = "Organization X";
    /// var response = await client.UpdateOrganization(result.Organization);
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a boolean indicating success and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(bool Success, NinjaApiError? Error)> UpdateOrganization(OrganizationBase organization)
    {
        var request = new RestRequest(string.Format(Resource.Organization, organization.Id));

        return await PostResource(request, organization.UpdateOrganizationDto(), Method.Patch);
    }
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/createLocationForOrganization
    // TODO: Implement CreateOrganizationLocation
    
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getInstallerForLocation
    // TODO: Implement GetOrganizationLocationInstaller
    
    // TODO: Account for custom installers
    /// <summary>
    /// Generate custom NinjaOne installer.<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getInstaller">getInstaller</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="organizationId">Id of the organization</param>
    /// <param name="locationId">Id of the location</param>
    /// <param name="installerType">Type of installer to generate</param>
    /// <example>
    /// <code>
    /// var result = await client.CreateOrganizationLocationInstaller(
    ///     organizationId: 1,
    ///     locationId: 5,
    ///     installerType: InstallerType.WINDOWS_MSI
    /// );
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable <see cref="Installer"/> and a nullable <see cref="NinjaApiError"/></returns>
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