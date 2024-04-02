namespace NinjaOne_Api.Library;

public partial class Client
{
    /// <summary>
    /// Get a list of device Ids belonging to a device group<br/>
    /// <a href="https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getGroupDeviceIds">getGroupDeviceIds</a>
    /// on Ninja One Public API Reference
    /// </summary>
    /// <param name="groupId">Id of the group</param>
    /// <example>
    /// <code>
    /// var result = await client.GetGroupMembers(groupId: 1);
    /// </code>
    /// </example>
    /// <returns>A named tuple comprised of a nullable list of device ids and a nullable <see cref="NinjaApiError"/></returns>
    public async Task<(List<int>? GroupMembers, NinjaApiError? Error)> GetGroupMembers(int groupId)
    {
        var request = new RestRequest(string.Format(Resource.GroupMembers, groupId));

        return await GetResources<int>(request);
    }
}