namespace NinjaOne_Api.Library;

public partial class Client
{
    // https://app.ninjarmm.com/apidocs-beta/core-resources/operations/getGroupDeviceIds
    public async Task<IList<int>> GetGroupMembers(int groupId)
    {
        var request = new RestRequest(string.Format(Resource.GroupMembers, groupId));

        return await GetResources<int>(request);
    }
}